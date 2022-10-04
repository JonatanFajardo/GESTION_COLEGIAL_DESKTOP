using System.Security.Cryptography;
using System.Text;

namespace Gestion.Colegial.Business.Helpers
{
    public static class SecurityEncryptation
    {
        //static readonly string password = "P455W0rd";
        public static string Encrypt(string plainText)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(plainText));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}