using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class circle : shape1
    {



        public circle()
        {
            Console.WriteLine("Enter radius");
            radius= Convert.ToInt32(Console.ReadLine());

        }
       
        public override float area()
        {
            return radius*radius*3;

        }

        public override float circumference()
        {
            return 2 * radius*3;
        }


    }

}
