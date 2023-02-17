using System.Security.Cryptography;
using System.Text;

namespace SHA1String
{
    public class Encoder
    {
        public static string EncodeString(string input, bool useSHA1 = false)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            if (useSHA1)
                return GetEncodedStringSHA1(input);
            string res = "";
            foreach (char ch in input)
            {
                char s = ch;
                s++;
                res += s;
            }
            return res;
        }

        //Вторая версия реализации кодирования шифра
        public static string EncodeStringV2(string input)
        {
            var encodedInput = GetEncodedStringSHA1(input);
            string res = "";
            foreach (char ch in encodedInput)
            {
                char s = ch;
                s++;
                res += s;
            }
            return res;
        }

        //Простая реализация кодирования алгоритмом SHA-1
        private static string GetEncodedStringSHA1(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(hash);
            }
        }
    }
}
