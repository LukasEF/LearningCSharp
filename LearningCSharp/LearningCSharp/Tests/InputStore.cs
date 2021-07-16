using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class InputStore
    {
        string data = "";
        int num = 0;

        public InputStore()
        {
            setData();
        }

        public void setData()
        {
            Console.WriteLine("Enter Data: ");
            data = Console.ReadLine();
            Console.WriteLine("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        public void printData()
        {
            Console.WriteLine("Data: " + data);
            Console.WriteLine("Number: " + num);
        }
    }
}
