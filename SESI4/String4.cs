using System;

class String4
{
    public static void Main()
    {
        string stringAwal = "C# membuat string mudah.";

        //How to substring
        string substr = stringAwal.Substring(5, 12);

        Console.WriteLine("stringawal: " + stringAwal);
        Console.WriteLine("substring: " + substr);
    }
}