using System;

    class Program
    {
        static void Main(string[] args)
        {   
            int range;
            int firstInt = 1; 
            Console.Write("Enter the range:");
            range = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= range; i++)
            {
                for (int j = 1; j < range - i + 1; j++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(firstInt++);
                }
                firstInt--;
                for (int m = 1; m < i; m++)
                {
                    Console.Write(--firstInt); 
                }
                Console.WriteLine();

            }
        }
    }