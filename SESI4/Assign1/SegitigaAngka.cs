using System;

// Segitiga Alfabet
// Input: Jumlah baris yang diingiinginkan menggunakan angka saja contoh "5" dengan nilai maximum 9
// Output: Menampilkan piramida dengan struktur angka 

    class SegitigaAngka
    {
        static void Main(string[] args)
        {   
            int range;
            int firstInt = 1; 
            Console.Write("Enter the range (1-9):");
            range = Convert.ToInt32(Console.ReadLine());
            if (range > 9 || range < 1){
                Console.WriteLine("Range yang dimasukan melewati batas optimal");
            }else{
                for (int i = 1; i <= range; i++)
                {
                    for (int j = 1; j < range - i + 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(firstInt++);
                    }
                    firstInt--;
                    for (int m = 1; m < i; m++)
                    {
                        Console.Write(--firstInt); 
                    }
                    Console.WriteLine();

                }
            }
            
        }
    }