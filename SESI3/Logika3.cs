using System;

    class Logika3
    {
        static void Main(string[] args)
        {   
           string Username;
           string Password;

           Console.Write("Username: ");
           Username = Console.ReadLine();
           Console.Write("Password: ");
           Password = Console.ReadLine();

           if (Username == "ocbc" && Password == "bootcamp"){
               Console.WriteLine("Anda berhasil login");
           } else{
               Console.WriteLine("Username atau Password anda salah");
           }
        }
    }