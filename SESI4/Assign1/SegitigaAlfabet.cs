using System;

    class SegitigaAlfabet
    {
        static void Main(string[] args)
        {
            int range;
            char firstChar = 'A'; 
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
                    Console.Write(firstChar++);
                }
                firstChar--;
                for (int m = 1; m < i; m++)
                {
                    Console.Write(--firstChar); 
                }
                Console.WriteLine();

            }
        }
    }