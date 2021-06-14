using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class student:person
    {
        public void gotoclass()
        {
            Console.WriteLine("I am going to class");
        }

        public void showage()
        {
            Console.WriteLine("my age is" + getage() + "years old");
        }
    }
}
