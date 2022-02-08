using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenadd
{
    class Program
    {

        static void Main(string[] args)
        {

            int limit, totaleven = 0, totalodd = 0;
            Console.WriteLine("enter the sum of odd and even numbers");
            limit = Convert.ToInt32(Console.ReadLine());
            for (int num = 0; num < limit; num++)
            {
                if (num % 2 == 0)
                {
                    Console.Write(" {0}", num);
                    totaleven = totaleven + num;
                }
                else
                {
                    Console.WriteLine(" \t {0}", num);
                    totalodd = totalodd + num;
                }
            }
            Console.WriteLine(" \n sum of all even numbers are : {0} \n sum of all odd numbers are : {1}", totaleven, totalodd);
            Console.ReadLine();
        }
    }
}

