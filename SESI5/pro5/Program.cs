using System;

namespace pro5
{
    class Program
    {
        public int bilangan1, bilangan2;

        public void bilangan(int angka1, int angka2)
        {
            bilangan1 = angka1;
            bilangan2 = angka2;
        }

        public virtual void penjumlahanPerkalianDll()
        {
            Console.WriteLine("Overiding 1......------>>>>");
            Console.WriteLine("Hasil penjumlahan angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 + bilangan2);
            Console.WriteLine("Hasil perkalian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 * bilangan2);
        }
    }

    class overide:Program
    {
        public override void penjumlahanPerkalianDll()
        {
            Console.WriteLine("Overiding 2......------>>>>");
            Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 / bilangan2);
            Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 - bilangan2);
        }

        static void Main()
        {
            Program overriding = new Program();
            bool startOverride = false;
            Console.WriteLine("======= Contoh Overriding ======= \n");
            do
            {
                Console.WriteLine("Masukan bilangan pertama :");
                int input_bil1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Masukan bilangan kedua :");
                int input_bil2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Bilangan pertama anda adalah: {input_bil1}, sedangkan bilangan kedua anda adalah {input_bil2}");
                Console.WriteLine("Ketik 'ya' apabila ingin mengganti angka, atau enter untuk mulai overriding :");
                string change = Console.ReadLine();

                if (change == "ya"){
                    startOverride = false;
                }else{
                    startOverride = true;
                }

            } while (startOverride == false);


            overriding.bilangan(10, 5);
            overriding.penjumlahanPerkalianDll();
            overriding = new overide();
            overriding.bilangan(20, 5);
            overriding.penjumlahanPerkalianDll();
            Console.Read();
        }
    }

}
