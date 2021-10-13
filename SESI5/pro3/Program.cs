using System;

namespace pro3
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            pesawat_tempur pswtempur = new pesawat_tempur();

            Console.WriteLine("Masukan nama kapal global :");
            pesawat.Nama = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Jumlah roda untuk kapal {0} :", pesawat.Nama);
            pesawat.JumlahRoda = Convert.ToInt32(Console.ReadLine());
            pesawat.Ketinggian = "1000 kaki";
            pesawat.JumlahPenumpang = "3 penumpang";
            pswtempur.Nama = "AZ500TPU";
            pswtempur.JumlahRoda = 5;
            pswtempur.Ketinggian = "200 kaki";
            pswtempur.JumlahPenumpang = "2 Penumpang plus kopilot dan assistance";
            Console.WriteLine();

            //Data Pesawat Global
            Console.WriteLine("======== Data Pesawat Global ========");
            Console.WriteLine($"Kapal secara global bernama {pesawat.Nama} dan memiliki roda sebanyak {pesawat.JumlahRoda}");
            pesawat.terbang();
            Console.WriteLine();

            //Data Pesawat Tempur
            Console.WriteLine("======== Data Pesawat Tempur ========");
            pswtempur.terbangTinggi();
            pswtempur.terbang();
            Console.WriteLine();
            Console.Read();
        }
    }
}
