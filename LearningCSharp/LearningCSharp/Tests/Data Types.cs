using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class Data_Types
    {
        //Data types
        static int num = 10;
        static double dub = 5.99D;
        static long bigNum = 15000000000L;
        static char letter = 'W';
        static bool myBool = true;
        static string name = "lukas";

        public static void print_vars()
        {
            Console.WriteLine("int: " + num);
            Console.WriteLine("double: " + dub);
            Console.WriteLine("long: " + bigNum);
            Console.WriteLine("char: " + letter);
            Console.WriteLine("bool: " + myBool);
            Console.WriteLine("string: " + name);
        }
    }
}
