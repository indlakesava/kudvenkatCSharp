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
                //Properties
                case 26:
                    Introduction introduction26 = new Introduction();
                    introduction26.twentySix();
                    break;
                //Properties
                case 27:
                    Introduction introduction27 = new Introduction();
                    introduction27.twentySeven();
                    break;
                //Structs
                case 28:
                    Introduction introduction28 = new Introduction();
                    introduction28.twentyEight();
                    break;
                //Class vs Struct
                case 29:
                    Introduction introduction29 = new Introduction();
                    introduction29.twentyNine();
                    break;
                //Interfaces
                case 30:
                    Introduction introduction30 = new Introduction();
                    introduction30.thirty();
                    break;
                //Explicit Interface Implementation
                case 31:
                    Introduction introduction31 = new Introduction();
                    introduction31.thirtyOne();
                    break;
                //Abstract Classes
                case 32:
                    Introduction introduction32 = new Introduction();
                    introduction32.thirtyTwo();
                    break;
                //Delegates
                case 36:
                    Introduction introduction36 = new Introduction();
                    introduction36.thirtySix();
                    break;
                //Delegates usage
                case 37:
                    Introduction introduction37 = new Introduction();
                    introduction37.thirtySeven();
                    break;
                //Delegates usage
                case 38:
                    Introduction introduction38 = new Introduction();
                    introduction38.thirtyEight();
                    break;
                //Multicast Delegates
                case 39:
                    Introduction introduction39 = new Introduction();
                    introduction39.thirtyNine();
                    break;
                //Exception Handling
                case 40:
                    Introduction introduction40 = new Introduction();
                    introduction40.fourty();
                    break;
                //Inner Exception
                case 41:
                    Introduction introduction41 = new Introduction();
                    introduction41.fourtyOne();
                    break;
                //Custom Exceptions
                case 42:
                    Introduction introduction42 = new Introduction();
                    introduction42.fourtyTwo();
                    break;
                //Custom Exceptions
                case 43:
                    Introduction introduction43 = new Introduction();
                    introduction43.fourtyThree();
                    break;
                //Custom Exceptions
                case 44:
                    Introduction introduction44 = new Introduction();
                    introduction44.fourtyFour();
                    break;
                //Enums
                case 45:
                    Introduction introduction45 = new Introduction();
                    introduction45.fourtyFive();
                    break;
                //Enums Example
                case 46:
                    Introduction introduction46 = new Introduction();
                    introduction46.fourtySix();
                    break;
                //Enums Tutorial
                case 47:
                    Introduction introduction47 = new Introduction();
                    introduction47.fourtySeven();
                    break;
                //Attributes
                case 52:
                    Introduction introduction52 = new Introduction();
                    introduction52.fiftyTwo();
                    break;
                //Reflection
                case 53:
                    Introduction introduction53 = new Introduction();
                    introduction53.fiftyThree();
                    break;
                //Late Binding using Reflection
                case 55:
                    Introduction introduction55 = new Introduction();
                    introduction55.fiftyFive();
                    break;
                //Generics
                case 56:
                    Introduction introduction56 = new Introduction();
                    introduction56.fiftySix();
                    break;
                //Why should we override ToString method
                case 57:
                    Introduction introduction57 = new Introduction();
                    introduction57.fiftySeven();
                    break;
                //Why should we override Equals method
                case 58:
                    Introduction introduction58 = new Introduction();
                    introduction58.fiftyEight();
                    break;
                //Convert.Tostring() vs ToString()
                case 59:
                    Introduction introduction59 = new Introduction();
                    introduction59.fiftyNine();
                    break;
                //String vs StringBuilder
                case 60:
                    Introduction introduction60 = new Introduction();
                    introduction60.sixty();
                    break;
                //Partial Classes
                case 61:
                    Introduction introduction61 = new Introduction();
                    introduction61.sixtyOne();
                    break;
                //Partial Methods
                case 63:
                    Introduction introduction63 = new Introduction();
                    introduction63.sixtyThree();
                    break;
                //Optional Parameters - using params
                case 67:
                    Introduction introduction67 = new Introduction();
                    introduction67.sixtySeven();
                    break;
                //Optional Parameters - using method overloading
                case 68:
                    Introduction introduction68 = new Introduction();
                    introduction68.sixtyEight();
                    break;
                //Optional Parameters - using parameter defaults
                case 69:
                    Introduction introduction69 = new Introduction();
                    introduction69.sixtyNine();
                    break;
                //Optional Parameters - using OptionalAttribute
                case 70:
                    Introduction introduction70 = new Introduction();
                    introduction70.seventy();
                    break;
                //Dictionary - 72, 73
                case 72:
                    Introduction introduction72 = new Introduction();
                    introduction72.seventyTwo();
                    break;
                //List - 74, 75
                case 74:
                    Introduction introduction74 = new Introduction();
                    introduction74.seventyFour();
                    break;
                //List - 76
                case 76:
                    Introduction introduction76 = new Introduction();
                    introduction76.seventySix();
                    break;
                //Sorting a list of simple types
                case 77:
                    Introduction introduction77 = new Introduction();
                    introduction77.seventySeven();
                    break;
                //Sorting a list of simple types
                case 78:
                    Introduction introduction78 = new Introduction();
                    introduction78.seventyEight();
                    break;
                //Sorting a list of simple types - using Comparision delegate
                case 79:
                    Introduction introduction79 = new Introduction();
                    introduction79.seventyNine();
                    break;
                //Useful methods of lis collection
                case 80:
                    Introduction introduction80 = new Introduction();
                    introduction80.eighty();
                    break;
                //Queue
                case 82:
                    Introduction introduction82 = new Introduction();
                    introduction82.eightyTwo();
                    break;
                //Queue
                case 83:
                    Introduction introduction83 = new Introduction();
                    introduction83.eightyThree();
                    break;
                //retrieving data from thread function using call back function
                case 91:
                    Introduction introduction91 = new Introduction();
                    introduction91.nintyOne();
                    break;
                //Anonymous Methods
                case 98:
                    Introduction introduction98 = new Introduction();
                    introduction98.nintyEight();
                    break;
                //Anonymous Methods
                case 99:
                    Introduction introduction99 = new Introduction();
                    introduction99.nintyNine();
                    break;
                //Func Delegate
                case 100:
                    Introduction introduction100 = new Introduction();
                    introduction100.hundered();
                    break;
                default:
                    Console.WriteLine("Input case not found");
                    break;
            }
        }
    }
}
