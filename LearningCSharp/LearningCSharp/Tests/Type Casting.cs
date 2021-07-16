using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class Type_Casting
    {
        //Type casting//

        //Implicit casting
        public static void implicit_cast()
        {
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine("9 implicitly cast to double");
            Console.WriteLine(myDouble);
        }

        //Explicit casting
        public static void explicit_cast()
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble;
            Console.WriteLine("9.78 explicitly cast to int");
            Console.WriteLine(myInt);
        }

        //Using conversion methods to cast
        public static void conversion_methods()
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine("int to string: " + Convert.ToString(myInt));
            Console.WriteLine("int to double: " + Convert.ToDouble(myInt));
            Console.WriteLine("double to int: " + Convert.ToInt32(myDouble));
            Console.WriteLine("bool to string: " + Convert.ToString(myBool));
        }
    }
}
