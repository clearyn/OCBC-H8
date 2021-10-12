using System;
using System.Collections.Generic;
using System.Linq;

    class ConverterAngka
    {
        static void Main(string[] args)
        {   
            //Untuk soal 5 & 6 Polymorph palindrome
            Console.Write("Enter the numbers or words: ");
            string numbers = Convert.ToString(Console.ReadLine());
            //Convert string to char
            char[] arrayNumber = numbers.ToCharArray();
            Console.Write("Reversed & Converted Word: ");
            //Convert using switch
            Array.Reverse( arrayNumber);
            foreach (var item in arrayNumber)
            {   
                string choice = " ";
                switch (item)
                {
                    case '1':
                        choice = "One";
                        break;
                    case '2':
                        choice = "Two";
                        break;
                    case '3':
                        choice = "Three";
                        break;
                    case '4':
                        choice = "Four";
                        break;
                    case '5':
                        choice = "Five";
                        break;
                    case '6':
                        choice = "Six";
                        break;
                    case '7':
                        choice = "Seven";
                        break;
                    case '8':
                        choice = "Eight";
                        break;
                    case '9':
                        choice = "Eight";
                        break;
                    default:
                        choice = Convert.ToString(item);
                        break;
                }
                Console.Write(choice + " ");
                
            }
            Console.WriteLine();

        }
    }