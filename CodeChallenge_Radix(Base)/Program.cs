using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_Radix_Base_
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int reminder ;
            int counter = 0;
            int times = 0;

            while (n>0)
            {
                reminder = n % 2;
                n = n / 2;
                if(reminder ==1)
                {
                     counter++;
                    if(counter > times)
                    {
                        times = counter;
                    }
                }

                else
                {
                    counter = 0;
                }
            }

            Console.WriteLine(times);
            Console.ReadLine();
        }
    }
}
