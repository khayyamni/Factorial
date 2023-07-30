using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static_Extention_Struct.Extentions
{
    internal static class CustomExtentions
    {
        public static int Sum(this int number, int num2)
        {
            return number + num2;
        }

        public static bool HasStr(this string text, string search)
        {
            return text.Contains(search);
        }

        public static bool CheckDigitOfString(this string str, string pattern)
        {
            return Regex.IsMatch(str, pattern   );
        }

        public static void Test (this Book book)
        {
            Console.WriteLine(book.Name);
        }
    }
}
