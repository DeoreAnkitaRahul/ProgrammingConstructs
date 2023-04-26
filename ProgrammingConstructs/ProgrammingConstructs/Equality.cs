using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class Equality
    {
             public int i;
        public void PowerOfTwo()
        {
            Console.WriteLine("Enter the Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                Console.WriteLine($"The Table of 2 * {i} = {2 * i}");
            }


        }

            

        
    }
}


