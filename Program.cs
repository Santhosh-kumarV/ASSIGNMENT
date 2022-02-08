using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double avg = 0, avg1 = 0;
            double sum = 0, sum1 = 0;
            int a;
            Console.WriteLine("enter a number");
            for (int i=1;i<=5;i++)
            {

              a = Convert.ToInt32(Console.ReadLine());
                if(a>0)
                {
                    sum = sum + a;

                }
                else
                {
                    sum1 = sum1 - a;

                }
            }
            avg = sum / 10;
            avg1 = sum1 / 10;
            Console.WriteLine("sum of all numbers +ve numbers:" + sum);
            Console.WriteLine("sum of all numbers -ve numbers:" + sum1);
            Console.WriteLine("avg of all numbers +ve numbers:" + avg);
            Console.WriteLine("avg all numbers -ve numbers:" + avg1);
            Console.ReadLine();
            
            }
        }
    }

