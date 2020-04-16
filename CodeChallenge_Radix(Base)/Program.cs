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
            int reminder;
            var numberList = new List<int>();

            while (n>2)
            {
                reminder = n % 2;
                n = n / 2;
                numberList.Add(reminder);

            }
        }
    }
}
