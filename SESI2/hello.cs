using System;

class Hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello nama kalian");
        Console.WriteLine("Selamat datang di program bootcamp ocbc");
        Console.WriteLine("Tahap 1 saya akan belajar c# atau csharp");

        string namaCustomer = "Foxi";
        double harga1 = 10.000, harga2 = 20.000, harga3 = 30.000;
        int jumlah1 = 5, jumlah2 = 10, jumlah3 = 20;

        double total1 = harga1*jumlah1;
        double total2 = harga2*jumlah2;
        double total3 = harga3*jumlah3;

        double totalSemuaBarang = total1+total2+total3;
        int totalJumlahBarang = jumlah1+jumlah2+jumlah3;
        Console.WriteLine();
        Console.WriteLine($"Nama : {namaCustomer}");
        Console.WriteLine($"barang 1 dengan harga {harga1} dan jumlah {jumlah1}, jumlah yang perlu dibayar {total1}");
        Console.WriteLine($"barang 2 dengan harga {harga2} dan jumlah {jumlah2}, jumlah yang perlu dibayar {total2}");
        Console.WriteLine($"barang 3 dengan harga {harga3} dan jumlah {jumlah3}, jumlah yang perlu dibayar {total3}");
        Console.WriteLine();
        Console.WriteLine($"Jumlah semua barang: {totalJumlahBarang}");
        Console.WriteLine($"Total harga semua barang: {totalSemuaBarang}");
        Console.WriteLine();
    }
}