using System;
using System.Collections.Generic;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        { 
            byte a=2;
            sbyte b=10;
            short c=11;

            int x=a+b+c;
            long y=x;
            double z=y;

            Console.WriteLine(x+"/"+y+"/"+z);



            string s="merhaba";
            char t='c';
            object o = s+t;
            Console.WriteLine(o);


            float f=5.6f;
            byte bb=(byte)f;
            Console.WriteLine(f+"//"+bb);

        }
    }
}