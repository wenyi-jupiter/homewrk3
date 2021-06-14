using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class complexnumber
    {
        private int real;
        private int img;
        public complexnumber(int a, int b)
        {
            real = a;
            img = b;
            
        }
        public void setimg(int i) {
            img = i;
        }

        public void setreal(int r)
        {
            real = r;
        }
        public string tostring()
        {
            string res = "(" + Convert.ToString(real) + "," + Convert.ToString(img) + ")";
            return res;
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(Math.Pow(real, 2) + Math.Pow(img, 2));
        }
        public void Add(complexnumber n1,complexnumber n2)
        {
            real=n1.real+n2.real;
            img=n1.img+n2.img;
        }

    }
}
