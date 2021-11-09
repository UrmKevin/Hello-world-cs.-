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

            Console.WriteLine("Hello " + firstname + "!");


            Console.Read();
        }
    }
}
