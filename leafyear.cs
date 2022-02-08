using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starpattern
{
    class leafyear
    {
        static void main(string[]args)
        {
            bool leaforNot = false;
            Console.WriteLine("enter a year");
            int y = Convert.ToInt32(Console.ReadLine());
            if(y%4==0&&y%100!=0)
            {
                Console.WriteLine("leaf year");
            }
            else if(y%100==0&&y%400==0)
            {
                Console.WriteLine("leaf year");
            }
            else
            {
                Console.WriteLine("not a leaf year");
            }
            Console.ReadLine();
        }
    }
}
