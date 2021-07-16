using System;
using TestSpace;
using Inheritance;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child(40, "Parent", 21, "Guy");
            c.displayChildAndParent();
        }
    }
}
