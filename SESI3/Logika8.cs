using System;

    class Logika5
    {
        static void Main(string[] args)
        {  
           Console.WriteLine("Angka awal pengulangan: ");
           int i = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Masukan batas akhir pengulangan: ");
           int l = Convert.ToInt32(Console.ReadLine());

           //Validation
           if(i > l){
               Console.WriteLine("Angka awal tidak boleh lebih besar dari angka akhir pengulangan!");
           }else{
               //Choice operator
                Console.WriteLine("Pilih operator untuk pengulangan (1,2,3,4)");
                int jenis =  Convert.ToInt32(Console.ReadLine());
                int d = 1;
                switch (jenis){
                    case 1:{
                        Console.WriteLine("Perkalian, masukan angka untuk perkalian: ");
                        break;
                    }case 2:{
                        Console.WriteLine("Pembagian, masukan angka untuk pembagian: ");
                        break;
                    }case 3:{
                        Console.WriteLine("Pengurangan, masukan angka untuk pengurangan: ");
                        break;
                    }case 4:{
                        Console.WriteLine("Penambahan,  masukan angka untuk penambahan: ");
                        break;
                    }default:{
                        Console.WriteLine("Penambahan, masukan angka untuk penambahan: ");
                        break;
                    }
                }
                d = Convert.ToInt32(Console.ReadLine());

                do{ 
                    int result = 0;
                    switch (jenis){
                        case 1:{
                            result = i*d;
                            break;
                        }case 2:{
                            result = i/d;
                            break;
                        }case 3:{
                            result = i-d;
                            break;
                        }case 4:{
                            result = i+d;
                            break;
                        }default:{
                            result = i+d;
                            break;
                        }
                    }
                    Console.Write("i = {0}", i);
                    i++;
                    Console.Write(" Hasil "+ result);
                    Console.WriteLine();
                } while (i < l+1);
           }
           
        }
    }