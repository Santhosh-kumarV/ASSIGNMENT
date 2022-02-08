using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofprime
{
    class Program
    {        static bool checkPrime(int numberToCheck)
        {
            if (numberToCheck == 1)
            {
                return false;
            }
            for (int i = 2;
                     i * i <= numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int PrimeSum(int s, int r)
        { 
            int sum = 0;
            for (int i = r; i >= s; i--)

            {

                // Check for prime
                bool isPrime = checkPrime(i);
                if (isPrime)
                {

                    // Sum the prime number
                    sum = sum + i;
                }
            }
        }
    

