using System;

class Project
{
    public static void Main(String[] args)
    {   
        int pertama, kedua, ketiga, total;
        double rata;

        Console.Write("Enter your biodata: ");
        string biodata = Convert.ToString(Console.ReadLine());
        Console.Write("Enter username you want: ");
        string username = Convert.ToString(Console.ReadLine());
        Console.Write($"U know the password right?, {username}: ");
        string password = Convert.ToString(Console.ReadLine());
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter your gender (male/female): ");
        string input_gender = Console.ReadLine();
        bool gender = (input_gender == "male")? true: (input_gender == "female")? false: false;
        Console.Write("Married? (yes/no): ");
        string input_married = Console.ReadLine();
        bool married = (input_married == "yes")? true: (input_married == "no")? false: false;
        
        //Condition
        bool gnext = (input_gender == "male"||input_gender == "female")? true : false;
        bool mnext = (input_married == "yes"||input_married == "no")? true : false;
        bool isAdult = age > 18;
        bool isPasswordValid = password == "OCBC";

        if (gnext == true && mnext == true)
        {
            if (isAdult && isPasswordValid)
            {   
                Console.WriteLine("==Menghitung Nilai==");
                Console.Write("Masukan nilai PERTAMA: ");
                pertama = int.Parse(Console.ReadLine());
                Console.Write("Masukan nilai KEDUA: ");
                kedua = int.Parse(Console.ReadLine());
                Console.Write("Masukan nilai KETIGA: ");
                ketiga = int.Parse(Console.ReadLine());

                total = pertama + kedua + ketiga;
                rata = total / 3.0;

                Console.WriteLine($"WELCOME TO THE CLUB! {username}");
                Console.WriteLine($"Umur: {age} tahun");
                Console.WriteLine($"Gender : {input_gender}");
                Console.WriteLine($"Is Married : {input_married}");
                Console.WriteLine("Total Nilai adalah: " + total);
                Console.WriteLine("Rata-rata Nilai adalah: " + rata);
            }
            else
            {
                Console.WriteLine("Sorry, try again!");
            }
        }
        else
        {
            Console.WriteLine("Sorry, invalid format");
        }

        
    }
}