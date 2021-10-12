using System;

class String1
{
    public static void Main()
    {
        char[] charArray = {'l',' ','s','t','r','i','n','g','.'};
        string str1 = new string(charArray);
        string str2 = "String lain.";

        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}