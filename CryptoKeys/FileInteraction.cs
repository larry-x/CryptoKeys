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
        public FileInteraction()
        {
            FPath = Path.Combine(Environment.CurrentDirectory, "secret.txt");
        }

        public string FPath { get; }

        public void CreateSecret(string pass)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FPath))
                {
                    sw.Write(pass);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string Login()
        {
            string line1 = "";
            try
            {
                using (StreamReader sr = new StreamReader(FPath))
                {
                    line1 = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return line1;
        }

        public Dictionary<string,string> GetItems()
        {
            Dictionary<string, string> keys = new Dictionary<string, string>();
            string[] line = new string[2];
            try
            {
                using (StreamReader sr = new StreamReader(FPath))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine().Split('|');
                        keys.Add(line[0], line[1]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return keys;
        }

        public void Entry(string line)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FPath, true))
                {
                    sw.Write(line);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<string> CopyPage()
        {
            List<string> keys = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(FPath))
                {
                    while (!sr.EndOfStream)
                    {
                        keys.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return keys;
        }

        public void Recreate(List<string> copy)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FPath, false))
                {
                    for (int i = 0; i < copy.Count-1; i++)
                    {
                        sw.WriteLine(copy[i]);
                    }
                    sw.Write(copy[copy.Count - 1]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
       
    }
}
