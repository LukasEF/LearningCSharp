using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Child : Parent
    {
        int numChild;
        string wordChild;

        public Child(int numParent, string wordParent, int numChild, string wordChild) : base(numParent, wordParent)
        {
            this.numChild = numChild;
            this.wordChild = wordChild;
        }

        public void displayChildAndParent()
        {
            Console.WriteLine(getParentVals() + $"the childs values are {numChild} and {wordChild}");
        }
    }
}
