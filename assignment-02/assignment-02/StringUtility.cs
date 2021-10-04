
namespace assignment_02
{
    public static class StringUtility
    {
        public static string ReverseString(this string str)
        {
            string newStr = "";
            for (int i = str.Length-1; i >= 0 ; i--) 
            {
                newStr += str[i];
            }
            return newStr;
        }
        public static string CapitalizeString(this string str)
        {
            string newStr = "";
            foreach (char c in str)
            {
                if( c >= 'a' && c <= 'z' || (c == 'æ' || c == 'ø' || c == 'å'))
                {
                    newStr += (char)(c - 32);
                } 
                else
                {
                    newStr += c;
                }
            }
            return newStr;
        }
        public static string LowercaseString(this string str)
        {
            string newStr = "";
            foreach (char c in str)
            {
                if( c >= 'A' && c <= 'Z' || (c == 'Æ' || c == 'Ø' || c == 'Å'))
                {
                    newStr += (char)(c + 32);
                }
                else
                {
                    newStr += c;
                }
            }
            return newStr;
        }
    }

}
