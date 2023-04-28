using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class Equality
    {
        public void NaturalNumber()
        {
            Console.WriteLine("Enter the Number upto 5");
            int sum = 0;
            int value = int.Parse(Console.ReadLine());
            for (int p = 1; p <= value; p++)
                sum = sum + p;
            Console.WriteLine($"Sum of Natural Number : {sum}");
        }
    }
}



       
    




