using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class SwitchCase
    {
        public static string switchTest(int option)
        {
            switch (option)
            {
                case 0:
                    return "Option 0";
                case 1:
                    return "Option 1";
                case 2:
                    return "Option 2";
                case 3:
                    return "Option 3";
                case 4:
                    return "Option 4";
                case 5:
                    return "Option 5";
                case 6:
                    return "Option 6";
                case 7:
                    return "Option 7";
                case 8:
                    return "Option 8";
                case 9:
                    return "Option 9";
                case 10:
                    return "Option 10";
                default:
                    return "Sorry only goes up to 10 :^)";

            }
        }
    }
}
