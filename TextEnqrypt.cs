using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class TextEnqrypt
    {
        public  string Encrypt(string data, string algorithm)
        {
            byte[] result = null;
            switch (algorithm.ToLower())
            {
                case "md5":
                    result = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(data));
                    break;
                case "sha1":
                    result = new SHA1CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(data));
                    break;
                case "sha256":
                    result = new SHA256CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(data));
                    break;
                case "sha512":
                    result = new SHA512CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(data));
                    break;
            }
            string hex = "";
            foreach (byte x in result)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }
    }
}
