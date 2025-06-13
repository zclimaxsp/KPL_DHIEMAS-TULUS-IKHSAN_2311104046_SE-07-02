using System;
using System.Collections.Generic;
using System.Text;

class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    class Program
    {
        static List<User> users = new List<User>();

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.Write("Pilih menu: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Register();
                        break;
                    case "2":
                        Login();
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }

                Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
                Console.ReadKey();
            }
        }

        static void Register()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = ReadPassword();

            users.Add(new User { Username = username, Password = password });
            Console.WriteLine("\nRegistrasi berhasil!");
        }

        static void Login()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = ReadPassword();

            var user = users.Find(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Console.WriteLine("\nLogin berhasil!");
            }
            else
            {
                Console.WriteLine("\nLogin gagal. Username atau password salah.");
            }
        }

        static string ReadPassword()
        {
            StringBuilder password = new StringBuilder();
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password.Append(key.KeyChar);
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password.Length--;
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);

            return password.ToString();
        }
    }
}