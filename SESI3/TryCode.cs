using System;

    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter any Number:");
            int first = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = first - 1; i == 1; i--)
            {
                
            }
            Console.Write($"Factorial of {first} is: {result}");


            // int range;
            // int firstInt = 1; 
            // Console.Write("Enter the range:");
            // range = Convert.ToInt32(Console.ReadLine());
            // for (int i = 1; i <= range; i++)
            // {
            //     for (int j = 1; j < range - i + 1; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     for (int k = 1; k <= i; k++)
            //     {
            //         Console.Write(firstInt++);
            //     }
            //     firstInt--;
            //     for (int m = 1; m < i; m++)
            //     {
            //         Console.Write(--firstInt); 
            //     }
            //     Console.WriteLine();

            // }
            // int range;
            // char firstChar = 'A'; 
            // Console.Write("Enter the range:");
            // range = Convert.ToInt32(Console.ReadLine());
            // for (int i = 1; i <= range; i++)
            // {
            //     for (int j = 1; j < range - i + 1; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     for (int k = 1; k <= i; k++)
            //     {
            //         Console.Write(firstChar++);
            //     }
            //     firstChar--;
            //     for (int m = 1; m < i; m++)
            //     {
            //         Console.Write(--firstChar); 
            //     }
            //     Console.WriteLine();

            // }
        }
    }