﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class Equality
    {
             public int num;
            public void WeekDayNumber()
            {
                Console.WriteLine("Enter the number");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("SUNDAY");
                        break;
                    case 2:
                        Console.WriteLine("MONDAY");
                        break;
                    case 3:
                        Console.WriteLine("TUESDAY");
                        break;
                    case 4:
                        Console.WriteLine("WEDNESDAY");
                        break;
                    case 5:
                        Console.WriteLine("THURSDAY");
                        break;
                    case 6:
                        Console.WriteLine("FRIDAY");
                        break;
                    case 7:
                        Console.WriteLine("SATURDAY");
                        break;
                }

            }

        
    }
}


