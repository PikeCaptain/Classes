﻿namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Greetings greetings = new Greetings(); 
            //
            greetings.Welcome();

            //
            Console.WriteLine("What is your name squire?");
            string userName = Console.ReadLine();
            
            greetings.Hello("landon")
        }
    }
}