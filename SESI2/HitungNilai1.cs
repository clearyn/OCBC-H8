using System;

class HitungNilai1
{
    public static void Main(string[] args)
    {   
        int pertama, kedua, ketiga, total;
        double rata;
        Console.WriteLine("==Menghitung Nilai==");
        Console.Write("Masukan nilai PERTAMA: ");
        pertama = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai KEDUA: ");
        kedua = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai KETIGA: ");
        ketiga = int.Parse(Console.ReadLine());

        total = pertama + kedua + ketiga;
        rata = total / 3.0;

        Console.WriteLine("Total Nilai adalah: "+ total);
        Console.WriteLine("Rata Rata Nilai adalah "+ rata);
        Console.Read();

        //COBA-COBA SAJA
        // List<int> numbers = new List<int>();  
        // bool end = false;
        // int total = 0;

        // while (end == false)
        // {
        //     Console.WriteLine("Masukan angka ke "+ (numbers.Count()));
        //     int number = int.Parse(Console.ReadLine());
        //     numbers.Add(number);
        //     total += number;
        //     bool next = false;
        //     while (next == false)
        //     {
        //         Console.WriteLine("Apakah sudah selesai (Ya/Tidak)");
        //         string choice = Console.ReadLine();
        //         if (choice == "Ya")break;
        //     }
        // }

        // Console.WriteLine("Total : " + total);
        // Console.WriteLine("RataRata : " + total/numbers.Length);
    }
}