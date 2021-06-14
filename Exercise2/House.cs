using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class House
    {
        protected int area;
        protected Door door;

        public House(int area)
        {
            this.area = area;
            door = new Door();
        }
        public int myarea
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }

        public Door Door
        {
            get
            {
                return door;
            }
            set
            {
                door = value;
            }
        }
        public virtual void showdata()
        {
            Console.WriteLine("I am a house, my area is {0}",area);
        }


    }
    class Door
    {
        private string color;

        public void showdata()
        {
            Console.WriteLine("I am a door, my color is {0}", color);
        }

        public string mycolor
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

       


    }
}
