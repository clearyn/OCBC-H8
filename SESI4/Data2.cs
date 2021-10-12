using System;
using System.Collections.Generic;

    class Data2
    {
        public static void Main()
        {   
            bool loop = true;
            string isLoop = " ";
            List<string> contoh = new List<string>();
            
            //Input data using list
            do{ 
                Console.Write("Add new data: ");
                string add = Convert.ToString(Console.ReadLine());
                contoh.Add(add);
                Console.Write("Type 1 to show all data, or just enter to add new data: ");
                isLoop = Convert.ToString(Console.ReadLine());
                if (isLoop == "1") loop = false;
            } while (loop == true);

            //Show all data
            Console.WriteLine("=======================");
            Console.WriteLine("Menampilkan semua data dalam array :");
            foreach (string contoh1 in contoh)
            {
                Console.WriteLine(contoh1);
            }
            Console.WriteLine("");
        }
    }