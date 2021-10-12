using System;
using System.Collections.Generic;
using System.Linq;

    class BalikAngka
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string numbers = Convert.ToString(Console.ReadLine());
            //Convert string to char
            char[] arrayNumber = numbers.ToCharArray();
            Console.Write("Reversed Number: ");
            //Reverse using array function
            Array.Reverse( arrayNumber);
            foreach (var item in arrayNumber)
            {
                Console.Write(item);
                
            }
            Console.WriteLine();
            Console.WriteLine("total index : "+ arrayNumber.Length);
            Console.WriteLine();

        }
    }