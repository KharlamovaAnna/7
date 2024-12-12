using System.Linq;

namespace Тумаков.Classes
{
    internal class ReverseString
    {
        public static string ReverseTheString(string stroka)
        {
            if (string.IsNullOrEmpty(stroka))
            {
                return stroka;
            }
            return new string(stroka.Reverse().ToArray());

        }    
    }
}
