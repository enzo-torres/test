using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            Console.WriteLine("Hello, coffee drinkers!");
            Console.WriteLine("Is the coffee empty?[y/n]");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'n') 
            {
                coffee.Refill();
            }
            else
            {
                Console.WriteLine("In this case I am going to refill it!");
                coffee.Refill();
            }

            Console.WriteLine("Do you want to drink it?[y/n]");
            answer = char.Parse(Console.ReadLine());
            if ( answer == 'y')
            {
                coffee.Drink();
                Console.WriteLine("It is empty now!");
            }
            else
            {
                Console.WriteLine("Why not? Are you nuts???");
                Console.WriteLine("Get out of here!!!!");
            }
        }
    }
}

