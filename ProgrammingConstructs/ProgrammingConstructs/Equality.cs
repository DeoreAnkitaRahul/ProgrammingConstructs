﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class Equality
    {
             public int Age;
        public void CheckEligibility()
        {
            Console.WriteLine("Enter Candidate Age");
            Age=Convert.ToInt32(Console.ReadLine());
            if (Age >= 18)
            {
                Console.WriteLine("You are eligible to voting");
            }
            else
            {
                Console.WriteLine("You are not eligible to voting");
            }

        }
    }
   
}
