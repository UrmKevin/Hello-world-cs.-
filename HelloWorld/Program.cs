using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //program asks the user to enter their first name
            //program asks the user using their first name

            Console.WriteLine("Enter your first name: ");
            string firstname = Console.ReadLine();

            //program asks the user to enter their first name
            //program asks the user using their first name

            Console.WriteLine("Enter your last name: ");
            string lastname = Console.ReadLine();

            //Console.WriteLine("Hello " + firstname + "!");

            //string interpolation
            Console.WriteLine($"Hello, {firstname} {lastname}!");




            Console.Read();
        }
    }
}
