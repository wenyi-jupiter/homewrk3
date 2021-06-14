using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;
            complexnumber n1 = new complexnumber(5, 2);
            Console.WriteLine("number is" + n1.tostring());

            n1.setreal(3);
            Console.WriteLine("number is" + n1.tostring());
            Console.WriteLine("magnitutude is" + n1.GetMagnitude());

            complexnumber n2 = new complexnumber(-1, 1);
            n2.Add(n1, n2);
            Console.WriteLine("after adding");
            Console.WriteLine(n2.tostring());
        }
    }
}
