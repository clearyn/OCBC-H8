using System;

class Project
{
    public static void Main(String[] args)
    {
        int nilai1 = 10;
        int nilai2 = 8;

        nilai1 = 15;

        Console.WriteLine($"Nilai 1 : {nilai1}");
        
        nilai2 += 6;

        Console.WriteLine($"nilai2 = {nilai2}");
    }
}