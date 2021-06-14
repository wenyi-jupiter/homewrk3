using System;

namespace Exercise1
{

    class Program
    {
        public static void calculate(shape1 s)
        {
            Console.WriteLine(s.area());
        }
        static void Main(String[] args)
        {
            shape1 rec = new rectangle();
            calculate(rec);

            shape1 cir = new circle();
            calculate(cir);
        }
    }
}
