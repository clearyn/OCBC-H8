using System;

    class Logika4
    {
        static void Main(string[] args)
        {  
           double Nilai;
           Console.Write("Nilai: ");
           Nilai = Convert.ToDouble(Console.ReadLine());

           if (Nilai >= 85){
               Console.WriteLine("Kamu mendapat grade A");
           }else if (Nilai >= 65){
               Console.WriteLine("Kamu mendapat grade B");
           }else if (Nilai >= 45){
               Console.WriteLine("Kamu mendapat grade C");
           }else if (Nilai <= 25){
               Console.WriteLine("Kamu mendapat grade D");
           }
        }
    }