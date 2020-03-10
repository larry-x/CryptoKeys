using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace CryptoKeys
{
    public class Hasher
    {
        public Hasher(string fp)
        {
            filepath = fp;
            pbk = new Rfc2898DeriveBytes(KEY, SALT);
            Key = pbk.GetBytes(32);
            IV = pbk.GetBytes(16);
        }

        private string filepath;
        private const string KEY = "JUSTICE JUSTICE YOU SHALL PURSUE";
        private readonly byte[] SALT = {0, 72, 49, 222, 164, 144, 7, 121};
        private byte[] Key;
        private byte[] IV;
        Rfc2898DeriveBytes pbk;

        public string ComputeHash(string password, byte[] salt)
        {
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, salt, 1001);
            byte[] hasharray = rfc.GetBytes(20);

            return Convert.ToBase64String(hasharray);
        }

        public byte[] GenerateSalt()
        {
            byte[] salt = new byte[8];
            RandomNumberGenerator ran = RandomNumberGenerator.Create();
            ran.GetBytes(salt);

            return salt;
        }

        public string Hash256(string text)
        {
            byte[] bytearray = Encoding.UTF8.GetBytes(text);
            SHA256Managed sha = new SHA256Managed();
            string hash = Convert.ToBase64String(sha.ComputeHash(bytearray));

            return hash;
        }

        public string Encrypt(string message)
        {
            string closetext = "";
            byte[] locked;

            using (RijndaelManaged ri = new RijndaelManaged())
            {
                ri.Padding = PaddingMode.PKCS7;
                ICryptoTransform encryptor = ri.CreateEncryptor(Key, IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(message);
                        }
                    }
                    locked = ms.ToArray();
                }
            }

            closetext = Convert.ToBase64String(locked);
            return closetext;
        }

        public string Decrypt(string message)
        {
            string opentext = "";
            byte[] buffer;

            using (RijndaelManaged ri = new RijndaelManaged())
            {
                ri.Padding = PaddingMode.PKCS7;
                ICryptoTransform decryptor = ri.CreateDecryptor(Key, IV);
                buffer = Convert.FromBase64String(message);

                using (MemoryStream ms = new MemoryStream(buffer))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            opentext = sr.ReadToEnd();
                        }
                    }
                }
            }

            return opentext;
        }

    }
}
