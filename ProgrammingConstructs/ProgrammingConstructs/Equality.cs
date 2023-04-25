using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class Equality
    {
        int num_One, num_Two, num_Three;

        public int num_one, num_two, num_three;
        public void CompareNumber()
        {
            Console.WriteLine("Enter 1st number: ");
            num_one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            num_two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number: ");
            num_three = Convert.ToInt32(Console.ReadLine());
            if (num_one > num_two)
            {
                if (num_one > num_three)
                {
                    Console.Write("Number first is the greatest");
                }
                else
                {
                    Console.Write("Number third is the greatest");
                }
            }
            else if (num_two > num_three)
            {
                Console.Write("Number Second is the greatest");
            }
            else
            {
                Console.Write("Number third is the greatest");
            }

        }

    }
}


