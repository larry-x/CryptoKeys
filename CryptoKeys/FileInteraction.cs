using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CryptoKeys
{
    public class FileInteraction
    {
        public FileInteraction(string fp, Hasher h)
        {
            hasher = h;
            FPath = fp;
        }

        public string FPath { get; }
        private Hasher hasher;

        public void CreateSecret(string pass)
        {
            byte[] bytesalt = hasher.GenerateSalt();
            string salt = Convert.ToBase64String(bytesalt);
            string hash = hasher.ComputeHash(pass, bytesalt);
            string line = hash + "¦" + salt;

            try
            {
                using (StreamWriter sw = new StreamWriter(FPath))
                {
                    sw.Write(hasher.Encrypt(line));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public bool Login(string attempt)
        {
            string[] line1 = PassLine();
            bool succeed = false;
            string tryhash = "";

            tryhash = hasher.ComputeHash(attempt, Convert.FromBase64String(line1[1]));
            succeed = (line1[0] == tryhash) ? true : false;
            return succeed;
        }

        public Dictionary<string,string> AllItems()
        {
            List<string> lines = new List<string>();
            string[] line = new string[2];

            Dictionary<string, string> keys = new Dictionary<string, string>();
            
            try
            {
                using (StreamReader sr = new StreamReader(FPath))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        lines.Add(hasher.Decrypt(sr.ReadLine()));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            foreach (string l in lines)
            {
                line = l.Split('¦');
                keys.Add(line[0], line[1]);
            }

            return keys;
        }

        public void Entry(string line)
        {
            line = hasher.Encrypt(line);
            try
            {
                using (StreamWriter sw = new StreamWriter(FPath, true))
                {
                    sw.Write("\n" + line);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<string> CopyPage()
        {
            string open = "";
            List<string> lines = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(FPath))
                {
                    while(!sr.EndOfStream)
                    {
                        open = hasher.Decrypt(sr.ReadLine());
                        lines.Add(open);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return lines;
        }

        public void Recreate(List<string> copy)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FPath, false))
                {
                    for (int i = 0; i < copy.Count-1; i++)
                    {
                        sw.WriteLine(hasher.Encrypt(copy[i]));
                    }
                    sw.Write(hasher.Encrypt(copy[copy.Count - 1]));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string[] PassLine()
        {
            string[] line = new string[2];

            try
            {
                using (StreamReader sr = new StreamReader(FPath))
                {
                    line = hasher.Decrypt(sr.ReadLine()).Split('¦');
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return line;
        }

    }
}
