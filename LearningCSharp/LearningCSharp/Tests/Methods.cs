using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class Methods
    {
        public static void testMethod()
        {
            Console.WriteLine("Test method");
        }

        public static void multipleCalls()
        {
            testMethod();
            testMethod();
            testMethod();
        }

        public static string paramMethod(int num = 1, string word = "word")
        {
            return $"The arguments passed are: {num} & {word}";
        }

        public static void namedArguments()
        {
            Console.WriteLine(paramMethod(word: "test", num: 5));
        }

        public static int overloadPlus(int x, int y)
        {
            return x + y;
        }

        public static double overloadPlus(double x, double y)
        {
            return x + y;
        }

    }
}
