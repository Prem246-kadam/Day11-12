using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11And12
{
    internal class Unique
    {
        public  void Uni()
        {
            int[] arr = { 1, 2, 3, 4, 5, 5, 6, 7, 7, 2, 8 };
            
            HashSet<int> set = new HashSet<int>(arr);
            
           foreach(int num in set)
            {
                Console.WriteLine("Unique elements are" + num);
           }


        }
    }
}
