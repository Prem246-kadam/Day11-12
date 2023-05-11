using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11And12
{
    internal class MaxAndMin

    {
        public void MaxMin()
        {
            int[] arr = { 11, 5, 44, 33, 88, 22, 44, 56, 10 };
            int max = arr[0];
            int min = arr[0];

                for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
                Console.WriteLine("Maximun element in array" +max);
                 Console.WriteLine("Minimum element in array" + min);

        }
    }
}
