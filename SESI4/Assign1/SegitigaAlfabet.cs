using System;

// Segitiga Alfabet
// Input: Jumlah baris yang diingiinginkan menggunakan angka saja contoh "5" dengan nilai maximum 20
// Output: Menampilkan piramida dengan struktur alphabet 

    class SegitigaAlfabet
    {
        static void Main(string[] args)
        {   
            int range;
            char firstChar = 'A'; 
            Console.Write("Enter the range (1-20):");
            range = Convert.ToInt32(Console.ReadLine());
            //Limit input accepted
            if (range > 20 || range < 1){
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
                        Console.Write(firstChar++);
                    }
                    firstChar--;
                    for (int m = 1; m < i; m++)
                    {
                        Console.Write(--firstChar); 
                    }
                    Console.WriteLine();

                }
            }
            
        }
    }