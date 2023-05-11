using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day11And12
{
    internal class DuplicateElement
    {
        int[] arr = { 1, 2, 3, 3, 4, 5, 6, 7, 2, 1 };
        int count = 0;
         public void Elements()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j =i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }

                }
            }
            Console.WriteLine(count);
        }

    }
}
