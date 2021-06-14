using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class smallapartment:House
    {
        public smallapartment()
            :base(50)
        {

        }

        public override void showdata()
        {
            Console.WriteLine("I am an apartment, my area is" + area);
        }


    }
}
