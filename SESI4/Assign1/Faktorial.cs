using System;

    class Faktorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = number;
            // Standard method but using largest first as real math calculation
            for (int i = number-1; i > 0; i--)
            {   
                Console.WriteLine($"Calculate {result} * {i}");
                result = result*i;
            }
            Console.WriteLine($"Factorial of {number}! is : {result}");

        }
    }