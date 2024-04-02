using System;
using System.Collections.Generic;
using System.Globalization;

namespace ArraysAndLists
{
    
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

           
            var evens = new List<int>() { };

            
            var odds = new List<int>() { };

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    evens.Add(myArray[i]);
                }
                else
                {
                    odds.Add(myArray[i]);
                }
            }



            /*foreach (int num in myArray)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }*/


            foreach (var number in evens)
            {
                Console.WriteLine($"{number} is even");
            }

            Console.WriteLine();

            for (int i = 1; i < odds.Count; i++) 
            {
                Console.WriteLine($"{odds[i]} is odd");
            }


        }
    }
}
