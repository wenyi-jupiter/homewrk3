using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class person
    {
        private int age;

        public void sayhello()
        {
            Console.WriteLine("hello");
        }
        public void setage(int a)
        {
           age = a;
        }
        public int getage()
        {
            return age;
        }
    }
}
