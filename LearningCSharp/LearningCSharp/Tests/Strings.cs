using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class Strings
    {
        static string template = "A long string to demonstrate stuff";

        public static int stringLength()
        {
            return template.Length;
        }

        public static string toUpperOrLower(int option)
        {
            if (option == 0)
            {
                return template.ToLower();
            }
            else if(option == 1)
            {
                return template.ToUpper();
            }

            return "Parameter must be 0 or 1";
        }

        public static string stringConcat(string str1, string str2)
        {
            return string.Concat(str1, str2);
        }

        public static string stringInterp(string str1, string str2)
        {
            return $"The strings passed are: {str1} {str2}";
        }

        public static char getChar(int index)
        {
            return template[index];
        }

        public static string getSubStr(int index)
        {
            return template.Substring(index);
        }
    }

}
