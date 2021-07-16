using System;

namespace LearningCSharp
{
    class Loops
    {
        public static void whileTest()
        {
            Console.WriteLine("While loop");
            int i = 0;
            while(i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void forTest()
        {
            Console.WriteLine("For loop");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void foreachTest()
        {
            Console.WriteLine("For each loop");
            string[] words = { "lukas", "is", "cool" };
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
