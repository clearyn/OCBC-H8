using System;

namespace pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            pesawat.nama = "GARUDAKU";
            pesawat.p_ketinggian = "2500 kaki";

            pesawat.terbang();
            pesawat.sudahTerbang();
            Console.Read();
        }
    }
}
