using System;

    class Logika5
    {
        static void Main(string[] args)
        {  
           int nilai;
           nilai = 7;
           switch (nilai)
           {
               case 1:{
                   Console.WriteLine("Januari");
               }case 2:{
                   Console.WriteLine("Februari");
               }case 3:{
                   Console.WriteLine("Maret");
               }case 4:{
                   Console.WriteLine("April");
               }case 5:{
                   Console.WriteLine("Mei");
               }case 6:{
                   Console.WriteLine("Juni");
               }case 7:{
                   Console.WriteLine("July");
               }case 8:{
                   Console.WriteLine("Agustus");
               }case 9:{
                   Console.WriteLine("September");
               }case 10:{
                   Console.WriteLine("Oktober");
               }case 11:{
                   Console.WriteLine("November");
               }case 12:{
                   Console.WriteLine("Desember");
               }default:{
                   Console.WriteLine("1 Tahun hanya ada 12 bulan");
               }
                    
           }
        }
    }