using System;

namespace SESI1_Tambahan
{
    class Program
    {
        static void Main(string[] args)
        {
            String nama, alamat;
            int umur;
            // DateTime date;

            Console.WriteLine("Masukan nama: ");
            nama = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Masukan alamat: ");
            alamat = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Masukan Umur: ");
            umur = int.Parse(Console.ReadLine());

            // Console.WriteLine("Tanggal Lahir: ");
            // date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Terima kasih {nama}, berikut data yang anda masukan: \n");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"Alamat: {alamat}");
            Console.WriteLine($"Umur: {umur}");
            // Console.WriteLine($"Tanggal Lahir: {date}");
        }
    }

}
