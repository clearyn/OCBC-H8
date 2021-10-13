using System;

namespace pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //New object by reference
            Laptop laptop1 = new Laptop();

            //Attribute access, set attribute
            laptop1.merk = "Lenovo";
            laptop1.ram = 4;
            laptop1.memory = 128;

            //Show attribute
            Console.WriteLine("\n Merk Laptop anda adalah {0}", laptop1.merk);
            Console.WriteLine("\n Kapasistas Ram ada {0}", laptop1.ram);
            Console.WriteLine("\n Kapasistas Memory {0}", laptop1.memory);

            //Method access
            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            //Tambahan setter pakai function
            Console.WriteLine("Masukan memory yang diinginkan");
            int new_memory = Convert.ToInt32(Console.ReadLine());
            laptop1.RewriteMemory(new_memory);
            Console.WriteLine("\nKapasistas Memory {0}", laptop1.memory);

            Console.Read();
        }
    }
}
