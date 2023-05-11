using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11And12
{
    internal class SumOfDigits
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        public void Sum()

        {
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            Console.WriteLine("Sum of numbers" + sum);
        }
        
    }
}
