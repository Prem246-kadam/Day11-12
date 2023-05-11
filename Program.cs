using System.Security.Cryptography.X509Certificates;

namespace Day11And12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlcome to Dat 11 and 12 programs!");
            Console.WriteLine("select options 1:Duplicate\n 2.Unique\n 3.MaxMin\n 4.reverse\n 5.SumOfDigit\n 6.");
            int option = Convert.ToInt32 (Console.ReadLine());

            switch(option)
                {

                case 1: 
                    DuplicateElement duplicate = new DuplicateElement();
                    duplicate.Elements();
                    break;

                case 2:
                    Unique unique = new Unique();
                    Console.WriteLine("unique elements are");
                    unique.Uni();
                     break;

                case 3:
                    MaxAndMin maxAndMin = new MaxAndMin();
                    Console.WriteLine("maximun and minimum elements are");
                    maxAndMin.MaxMin();
                    break;

                case 4:
                    ReverseEachWord reverseEach = new ReverseEachWord();
                    ReverseEachWord reverseEach1 = new ReverseEachWord();
                    reverseEach1.SecondMethod();
                  
                    reverseEach.Reverse();
                    break;

                case 5:
                    SumOfDigits sumOfDigits = new SumOfDigits();
                    sumOfDigits.Sum();
                    break;

                case 6:
                    TwoLowest twoLowest = new TwoLowest();
                    twoLowest.Lowest();
                    break;

            }
        }
    }
}