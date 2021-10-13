using System;

namespace pro4
{
    class Program
    {
        static void Main(string[] args)
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
            Console.Read();
        }
    }
}
