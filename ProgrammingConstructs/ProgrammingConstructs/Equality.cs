using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class Equality
    {
       public int num_One,num_Two;
        public void CompareNo()
        {
            Console.WriteLine("Enter First No");
            num_One=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second No");
            num_Two = Convert.ToInt32(Console.ReadLine());
             if (num_One == num_Two)
            {
                Console.WriteLine("Both Numbers Are Equal");
            }
             else
            {
                Console.WriteLine("Both Numbers Are Not Equal");
            }

        }
    }
   
}
