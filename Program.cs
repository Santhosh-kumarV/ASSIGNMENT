using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelvintofarenhit
{
    class Program
    {
        
        
            static void Main(string[] args)
            {
                Console.WriteLine("enter the amount of celsius");
                int celsius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("kelvin={0}", celsius + 273);
                Console.WriteLine("fahrenheit={0}", celsius * 18 / 10 + 32);
                Console.ReadLine();
            }
        }
    }


