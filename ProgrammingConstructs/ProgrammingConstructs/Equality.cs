using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class Equality
    {
       public int num_One;
        public void CompareNo()
        {
            Console.WriteLine("Enter Number");
            num_One=Convert.ToInt32(Console.ReadLine());
               if (num_One % 2 == 0)
            {
                Console.WriteLine("Given Number Is Even");
            }
             else
            {
                Console.WriteLine("Given Number Is Odd");
            }

        }
    }
   
}
