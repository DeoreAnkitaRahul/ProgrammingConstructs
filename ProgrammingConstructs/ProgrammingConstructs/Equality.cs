using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class Equality
    {

        public int n, sum = 0;
        public void Square()
        {
            Console.WriteLine("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The squares upto {0} terms are :", n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}  ", i * i);
                sum += i * i;
            }
            Console.WriteLine("The Sum of Squares of numbers upto {0} terms = {1}", n, sum);
       
       

        }    

        
    }
}


