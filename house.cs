﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            
                SmallApartment apartment = new SmallApartment();
                Person person = new Person("vijay");
                apartment.door = new House.Door("black");
                person.house = apartment;
                person.ShowData();
                Console.ReadLine();
            }
        