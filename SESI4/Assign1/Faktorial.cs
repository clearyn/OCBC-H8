using System;

    class Faktorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] factor = new int[]{};
            int result;
            for (int i = number - 1; i == 0; i--)
            {
                factor[factor.Length + 1] = i;
            }
            foreach (int item in factor)
            {
                result = 
            }
            Console.WriteLine($"Factorial of {factor.Length}");

        }
    }