using System;

namespace gabungan
{
    class Program
    {
        static void Main(string[] args)
        {   
            Program p = new Program();
            bool loop = true;

            do
            {
                Console.WriteLine("Selamat datang di program gabungan silahkan pilih menu: \n 1.Pesawat Tempur(Inheritance) \n 2.Overloading \n 3.Overriding \n 4.Tentang Saya \n 5.Exit \n");
                Console.WriteLine("Masukan Pilihan anda (1-5)");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("===== Pesawat ===== \n");
                        p.RunPesawat();
                        Console.WriteLine("===== Selesai ===== \n");
                        break;
                    case "2":
                        Console.WriteLine("===== Overloading ===== \n");
                        p.RunOverloading();
                        Console.WriteLine("===== Overloading Selesai ===== \n");
                        break;
                    case "3":
                        Console.WriteLine("===== Overriding ===== \n");
                        overide tryOverride = new overide();
                        tryOverride.Start();
                        Console.WriteLine("===== Overriding Selesai ===== \n");
                        break;
                    case "4":
                        Console.WriteLine("===== Tentang Saya ===== \n");
                        Console.WriteLine("Halo nama saya Ryan, saya suka mempelajari hal baru dan menciptakan sesuatu yang dapat berguna bagi banyak orang. Untuk itu saya mulai mempelajadi coding karena teknologi merupakan suatu yang menarik \n");
                        Console.WriteLine("===== Sekian dan Terima Kasih ===== \n");
                        break;
                    case "5":
                        Console.WriteLine("Program selesai, Terima kasih");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak tersedia");
                        break;
                }

            } while (loop == true);
            
        } 

        class Overriding
        {
            public int bilangan1,bilangan2;

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

        class overide:Overriding
        {
            public override void penjumlahanPerkalianDll()
            {
                Console.WriteLine("Overiding 2......------>>>>");
                Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 / bilangan2);
                Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 - bilangan2);
            }

            public void Start()
            {
                Overriding overriding = new Overriding();
                bool startOverride = false;
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
            }
        }
        public void RunPesawat()
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
        }

        public void RunOverloading()
        {
            data datanew = new data();
            bool startOverload = false;
            string input_data1 = " ";
            int input_data2 = 0;

            do
            {
                Console.WriteLine("Kata apa yang anda inginkan untuk fungsi overload :");
                input_data1 = Console.ReadLine();
                Console.WriteLine("Berapa angka yang anda inginkan untuk fungsi overload :");
                input_data2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ketik 'ya' apabila ingin mengganti input, atau enter untuk mulai Overloading :");
                string change = Console.ReadLine();

                if (change == "ya"){
                    startOverload = false;
                }else{
                    startOverload = true;
                }

            } while (startOverload == false);

            Console.WriteLine("Berikut hasil kedua input dari fungsi yang sama: ");
            datanew.print("Untuk kata : " + input_data1);
            datanew.print("Untuk angka : " + input_data2);
        }


    }
}
