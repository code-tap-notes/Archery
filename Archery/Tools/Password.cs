using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Archery.Tools
{
    public static class Password
    {
        public static string HashMD5(this string value)
        {
            byte[] valueBytes = System.Text.Encoding.Default.GetBytes(value); //memoriser un tableau byte.hexa
            MD5CryptoServiceProvider provider= new MD5CryptoServiceProvider();
            byte[] calcul = provider.ComputeHash(valueBytes);
            string result = "";
            foreach(byte b in calcul)
            {
                if (b < 16)
                    result += "0" + b.ToString("x");
                else
                    result +=   b.ToString("x");
            }
            return result;
        }
    }
}