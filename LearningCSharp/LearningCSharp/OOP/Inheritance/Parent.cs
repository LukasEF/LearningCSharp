using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Parent
    {
        int numParent;
        string wordParent;

        public Parent(int numParent, string wordParent)
        {
            this.numParent = numParent;
            this.wordParent = wordParent;
        }

        protected string getParentVals()
        {
            return $"Parent values are {numParent} and {wordParent}, ";
        }
    }
}
