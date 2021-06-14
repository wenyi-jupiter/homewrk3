using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    
    class rectangle:shape1
    {
        

        public rectangle()
        {
            Console.WriteLine("Enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width");
            width = Convert.ToInt32(Console.ReadLine());

        }
         public float getlength()
        {
            return length;
        }
        public override float area()
        {
            return length * width;
            
        }

        public override float circumference()
        {
            return 2 * length + 2 * width;
        }



    }
}
