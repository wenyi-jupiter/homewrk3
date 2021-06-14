using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = true;
            smallapartment mysap = new smallapartment();
            person myperson = new person();
            myperson.myname = "kishore";
            myperson.myhouse = mysap;
            myperson.showdata();

            if (debug)
            {
                Console.ReadLine();
            }
        }
    }
}
