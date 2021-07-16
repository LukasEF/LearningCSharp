using System;
using System.Collections.Generic;
using System.Text;

namespace TestSpace
{
    class TestClass
    {
        private int number;
        private string word;

        public TestClass(int number, string word)
        {
            this.number = number;
            this.word = word;
        }

        public int getNumber()
        {
            return number;
        }

        public string getWord()
        {
            return word;
        }
    }
}
