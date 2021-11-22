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
                    Introduction introduction1 = new Introduction();
                    introduction1.first();
                    break;
                //Reading and Writing to the Console
                case 2:
                    Introduction introduction2 = new Introduction();
                    introduction2.second();
                    break;
                //Built-in Types
                case 3:
                    Introduction introduction3 = new Introduction();
                    introduction3.third();
                    break;
                //String Type
                case 4:
                    Introduction introduction4 = new Introduction();
                    introduction4.fourth();
                    break;
                //Commom Operators
                case 5:
                    Introduction introduction5 = new Introduction();
                    introduction5.fifth();
                    break;
                //Nullable Types
                case 6:
                    Introduction introduction6 = new Introduction();
                    introduction6.sixth();
                    break;
                //Type Conversion
                case 7:
                    Introduction introduction7 = new Introduction();
                    introduction7.seventh();
                    break;
                //Arrays
                case 8:
                    Introduction introduction8 = new Introduction();
                    introduction8.eigth();
                    break;
                //Comments
                case 9:
                    Introduction introduction9 = new Introduction();
                    introduction9.ninth();
                    break;
                //If Statement
                case 10:
                    Introduction introduction10 = new Introduction();
                    introduction10.tenth();
                    break;
                //Switch Statement
                case 11:
                    Introduction introduction11 = new Introduction();
                    introduction11.eleventh();
                    break;
                //While Loop
                case 13:
                    Introduction introduction13 = new Introduction();
                    introduction13.thirteenth();
                    break;
                //Do While Loop
                case 14:
                    Introduction introduction14 = new Introduction();
                    introduction14.fourteenth();
                    break;
                //For loop
                case 15:
                    Introduction introduction15 = new Introduction();
                    introduction15.fifteenth();
                    break;
                //Methods
                case 16:
                    Introduction introduction16 = new Introduction();
                    introduction16.sixteenth();
                    break;
                //Method parameters
                case 17:
                    Introduction introduction17 = new Introduction();
                    introduction17.seventeenth();
                    break;
                //Namespaces
                case 18:
                    Introduction introduction18 = new Introduction();
                    introduction18.eighteenth();
                    break;
                //Classes
                case 19:
                    Introduction introduction19 = new Introduction();
                    introduction19.nineteenth();
                    break;
                //Static and Instance class members
                case 20:
                    Introduction introduction20 = new Introduction();
                    introduction20.twentieth();
                    break;
                //Inheritance
                case 21:
                    Introduction introduction21 = new Introduction();
                    introduction21.twentyFirst();
                    break;
                //Method Hiding
                case 22:
                    Introduction introduction22 = new Introduction();
                    introduction22.twentySecond();
                    break;
                //Polymorphism
                case 23:
                    Introduction introduction23 = new Introduction();
                    introduction23.twentyThird();
                    break;
                //Method Hiding vs Method Overriding
                case 24:
                    Introduction introduction24 = new Introduction();
                    introduction24.twentyFour();
                    break;
                //Method Overloading
                case 25:
                    Introduction introduction25 = new Introduction();
                    introduction25.add(3, 5);
                    introduction25.add(3.5f, 5.3f);
                    break;
                default:
                    Console.WriteLine("Input case not found");
                    break;
            }
        }
    }
}
