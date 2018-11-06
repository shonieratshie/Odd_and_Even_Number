using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Code by Ratshivhadelo Thimothy
//Date: 06/Nov/2018
//Email: s210032278@outlook.com

namespace Squire_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            int oddSquare = 0;
            int evenSquare = 0; ;
            int counter;
            int square = 1;
            const int maxValue = 20;
            string chara = "00";
            Console.WriteLine("Number Square  Odd    Even");
            Console.WriteLine("---------------------------");

            for (counter = 1; counter <= maxValue; counter++)
            {
                square = counter * counter;



                if (IsEven(square))
                {
                    evenSquare = square;
                    evenList.Add(evenSquare);
                }
                else
                {
                    evenSquare = int.Parse(chara);
                    
                }

                if (IsOdd(square))
                {
                    oddSquare = square;
                    oddList.Add(oddSquare);
                }
                else
                {
                    oddSquare = 00;
                }
                Console.WriteLine("{0}       {1}        {2}      {3} ", counter, square, oddSquare, evenSquare);

    

            }

            // Odd Number
            int[] odd = oddList.ToArray();

            Console.WriteLine("\n Odd Number (Odd Number of Square) \n");
            Console.WriteLine("Total Average Min Max");
            Console.WriteLine("---------------------------");
            int[] numbers = odd;

           // Console.WriteLine(oddAverage(numbers.Min(), numbers.Max()));
            Console.WriteLine("{0}     {1}    {2}   {3}", numbers.Count(), oddAverage(numbers.Min(), numbers.Max()), numbers.Min(),numbers.Max()); //1


            // Even Number
            int[] even = evenList.ToArray();

            Console.WriteLine("\n Even Number (Even number of square) \n");
            Console.WriteLine("Total Average Min Max");
            Console.WriteLine("---------------------------");
            int[] evennumbers = even;

            // Console.WriteLine(oddAverage(numbers.Min(), numbers.Max()));
            Console.WriteLine("{0}     {1}    {2}   {3}", evennumbers.Count(), oddAverage(evennumbers.Min(), evennumbers.Max()), evennumbers.Min(), evennumbers.Max()); //1




            Console.ReadLine();
        }
        public static decimal oddAverage(int a, int b)
        {
            return (decimal)(a + b) / 2;
        }
        public static decimal evenAverage(int a, int b)
        {
            return (decimal)(a + b) / 2;
        }


        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}
