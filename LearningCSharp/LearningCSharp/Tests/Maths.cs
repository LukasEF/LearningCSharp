using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class Maths
    {
        public static int getMax(int number1, int number2)
        {
            return Math.Max(number1, number2);
        }

        public static int getMin(int number1, int number2)
        {
            return Math.Min(number1, number2);
        }

        public static double getSquareRoot(double number)
        {
            return Math.Sqrt(number);
        }

        public static double getAbsolute(double number)
        {
            return Math.Abs(number);
        }

        public static double getRounded(double number)
        {
            return Math.Round(number);
        }
    }
}
