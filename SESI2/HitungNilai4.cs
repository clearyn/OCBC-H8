using System;

class Project
{
    public static void Main(String[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        bool isAdult = age > 18;
        bool isPasswordValid = password == "OCBC";

        if (isAdult && isPasswordValid)
        {
            Console.WriteLine("WELCOME TO THE CLUB!");
        }
        else
        {
            Console.WriteLine("Sorry, try again!");
        }
    }
}