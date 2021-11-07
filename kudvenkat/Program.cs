using System;
using kudvenkat.First;

namespace kudvenkat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number related to the program you want to run:");
            int input = Int16.Parse(Console.ReadLine());

            switch (input)
            {
                //Introduction
                case 1:
                    Introduction introduction = new Introduction();
                    introduction.first();
                    break;
            }
        }
    }
}
