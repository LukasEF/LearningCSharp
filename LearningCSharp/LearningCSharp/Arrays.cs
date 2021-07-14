using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class Arrays
    {
        static int[] templateArray = { 1, 2, 3, 4, 5 };
        static int length = templateArray.Length;

        public static int getElement(int index)
        {
            return templateArray[index];
        }

        public static void changeElement(int index, int value)
        {
            templateArray[index] = value;
        }

        public static int getLength()
        {
            return length;
        }

        public static void loopThroughArray()
        {
            foreach(int num in templateArray)
            {
                Console.WriteLine(num);
            }
        }

        public static void sortArray(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine("Sorted array: ");
            foreach(int num in array)
            {
                Console.Write(num + " ");
            }
        }


    }
}
