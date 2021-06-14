using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class person
    {
        protected string name;
        protected House house;

       // public person(string name,House house)
        //{
          //  this.name = name;
            //this.house = house;
        //}

      public string myname
        {
            get { return name; }
            set { name = value; }
        }

        public House myhouse
        {
            get { return house; }
            set { house = value; }
        }
        public void showdata()
        {
            Console.WriteLine("my name is {0}", name);
            house.showdata();
            house.Door.showdata();
        }
    }
}
