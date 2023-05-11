using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11And12
{
    internal class TwoLowest
    {
        public void Lowest()
        {
            int[] arr = { 1, 2, 3,4, 56, 5, 6, 7, -5, -6, -4 };
            
             Array.Sort(arr);
            int Low1 = arr[0];
            int Low2 = arr[1];

            Console.WriteLine("1 lowest:" + Low1);
            Console.WriteLine("2 lowest:" + Low2);
        }
    }
}
