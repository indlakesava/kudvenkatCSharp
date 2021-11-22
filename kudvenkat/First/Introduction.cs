using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace kudvenkat.First
{
    class Introduction
    {
        #region First
        //Introduction
        public void first()
        {
            Console.WriteLine("Welcome to C# Tutorials");
            first1();
        }
        
        private void first1()
        {
            Console.WriteLine("This function is called from main");
        }
        #endregion

        #region Second
        //Reading and Writing to the Console
        public void second()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);
            Console.WriteLine("Hello {0}", name);
            Console.Read();
        }
        #endregion

        #region Third
        //Built-in Types
        public void third()
        {
            bool b = true;
            int i = int.MaxValue;
            Console.WriteLine(i);
            float f = 0.25f;
            Console.WriteLine(f);
        }
        #endregion

        #region Fourth
        //String Type
        public void fourth()
        {
            //Escape Sequences
            String name = "\"Kesava\"";
            String new_line = "one\nTwo\nThree";
            String path = "C:\\Kesava\\College";
            //Verbatim Literal
            String path1 = @"C:\Kesava\College";
            Console.WriteLine(name);
            Console.WriteLine(new_line);
            Console.WriteLine(path);
            Console.WriteLine(path1);
        }
        #endregion

        #region Fifth
        //Commom Operators
        public void fifth()
        {
            //Assignment Operator =
            int num1 = 1;
            int num2 = 3;
            //Arithmetic Operator +, -, *, /, %
            Console.WriteLine(num1+num2*num1-num2/num1);
            //Comparision Operator ==, !=, >, >=, <, <=
            if (num1 >= num2 && num1<=num2)
            {
                Console.WriteLine(true);
            }
            //Conditional Operator &&, ||
            //Ternary Operator ?:
            Console.WriteLine(num1<num2?true:false);
            //Null Coalescing Operator ??
        }
        #endregion

        #region Sixth
        //Nullable Types
        /*
         * In C# types are divided into 2 broad categories
         * Value Types - int, float, double, structs, enums, etc.,
         * Reference Types - interface, class, delegates, arrays, etc.,
         * 
         * By default value types are non nullable, so to make them nullable use ?
         * int i = 0; i = null; is illegal
         * int? i = 0; i = null; is legal
         * 
         * Nullable types bridge the differences between C# types and Database types
        */
        public void sixth()
        {
            bool? AreYouMajor = null;
            if(AreYouMajor == true)
            {
                Console.WriteLine("I am a major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("I am not a major");
            }
            else if (AreYouMajor == null)
            {
                Console.WriteLine("unanswered");
            }

            //explicit conversion - no implicit conversion
            int? ticketsonsale = 100;
            int availabletickets;
            //availabletickets = ticketsonsale; cannot implicitly convert int? to int
            availabletickets = ticketsonsale.Value;
            availabletickets = (int)ticketsonsale;
            Console.WriteLine("availabletickets {0}", availabletickets);

            //Above code doesn't work if we have null value. We need if else to handle the case
            int? ticketsonsalee = null;
            int availableticketss;

            if(ticketsonsalee==null)
            {
                availableticketss = 0;
            }
            else
            {
                availableticketss = (int)ticketsonsalee;
            }

            int availableticketsss = ticketsonsalee ?? 0;
            Console.WriteLine("availabletickets {0}", availabletickets);
        }
        #endregion

        #region Seventh
        //Type conversions
        /*
         * Implicit Conversion is done by compiler
         * 1. when there is no loss of information if the conversion is done
         * 2. if there is no possibility of throwing exceptions during the conversion
         * ex: int -> float
         * 
         * float -> int need explicit conversion as we lose the fractional part and also a
         * possibility of overflow exception
         * 
         * for explicit conversion we can use either cast operator or the convert class
        */
        public void seventh()
        {
            int a = 1;
            float a_f = a;

            float b_f = 123.45f;
            //int b = b_f;can't convert
            int b = (int)b_f;
            int bb = Convert.ToInt32(b_f);

            float f = 12737334343337.45f;
            int i = (int)f;//-2147483648 which is the least value an int can hold 
            //its not correct conversion value instead it should throw error
            //type cast doesn't throw any error where as convert class throws system.OverflowException
            //i = Convert.ToInt32(f);
            //Error is thrown during runtimex
            Console.WriteLine(i);

            //If we are trying to convert anything from string format then parse method would be a good idea
            String str = "200";
            int str_i = int.Parse(str);
            Console.WriteLine(str_i);

            //If we are trying to conver from string to other datatype and which is not possible for example "100T" to int 100
            //In this case parse throws FormatExceprion. If we don't want the exception and want to handle it then use TryParse
            //Which converts only if possible
            String strNum = "100TG";
            int result = 0;
            bool isSuccessful = int.TryParse(strNum, out result);

            if (isSuccessful)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer");
            }
        }
        #endregion

        #region Eigth
        //Arrays
        /*
         * An array is a collection of similar datatypes
         * adv: 
         * Strongly typed
         * 
         * dis adv: 
         * Arrays cannot grow in size once initialized
         * Have to rely in integra indices to store or retrieve elements from an array 
        */
        public void eigth()
        {
            int[] evenNums = new int[3];
            evenNums[0] = 0;
            evenNums[1] = 2;
            evenNums[2] = 4;
            Console.WriteLine(evenNums[1]);
        }
        #endregion

        #region Ninth
        //Comments
        /// <summary>
        /// This is XML Documentation Comments.
        /// Hover over to this function call and check the tooltip.
        /// </summary>
        public void ninth()
        {
            //Shortcuts
            //ctrl+k ctrl+c to comment
            //ctrl+k ctrl+u to uncomment

            //Single Line Comments

            /*
             * Multi
             * Line
             * Comments
            */

        }
        #endregion

        #region Tenth
        /*
         * If, If Else, && and ||, & and |
        */
        public void tenth()
        {
            Console.WriteLine("Please enter a number");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("Your Number Is One");
            }
            if (userInput == 2)
            {
                Console.WriteLine("Your Number Is Two");
            }
            if (userInput == 3)
            {
                Console.WriteLine("Your Number Is Three");
            }
            if(userInput != 1 && userInput != 2 && userInput != 3)
            {
                Console.WriteLine("Your Number is not 1, 2, 3");
            }

            //If you have multiple if statements then every if statement is evaluated in many cases we don't need it
            //Instead use if, else if, else
            if (userInput == 1)
            {
                Console.WriteLine("Your Number Is One");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Your Number Is Two");
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Your Number Is Three");
            }
            else
            {
                Console.WriteLine("Your Number is not 1, 2, 3");
            }
        }
        #endregion

        #region Eleventh
        /*
         *We use switch to avoid multiple if else statements 
         */
        public void eleventh()
        {
            Console.WriteLine("Please enter a number:");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 10:
                    Console.WriteLine("Number entered is 10");
                    break;
                case 20:
                    Console.WriteLine("Number entered is 20");
                    break;
                default:
                    Console.WriteLine("Number entered is not 10 or 20");
                    break;
            }

            //Combining multiple case statements
            switch (num)
            {
                case 10:
                case 20:
                    Console.WriteLine("Number entered is {0}", num);
                    break;
                default:
                    Console.WriteLine("Number entered is not 10 or 20");
                    break;
            }
        }
        #endregion

        #region Twelfth
        //Switch, Goto, label are explained
        //Goto is bad programming style. We should avoid it by all means.
        #endregion

        #region Thirteenth
        /*
         * While loop
         * While loop checks for the condition first
         * if the condition is true, statements inside the while are executed
         * this process repeates until the condition evaluates to false
         * 
         * Always make sure you won't be creating a never ending loop
         * Don't forget to update the cariable participating in the condition so that the loop can end.
         */
        public void thirteenth()
        {
            Console.WriteLine("Enter target number till where you need to print");
            int target = int.Parse(Console.ReadLine());
            int start = 0;

            while(start <= target)
            {
                Console.WriteLine(start);
                start++;
            }
        }
        #endregion

        #region Fourteenth
        /*
         * Do While loop
         */
        public void fourteenth()
        {
            string user_input = "";
            do
            {
                Console.WriteLine("Do you want to continue?");
                user_input = Console.ReadLine();

                if (user_input != "yes" && user_input != "no")
                {
                    Console.WriteLine("Please enter a valid input");
                }
            } while (user_input != "yes" && user_input != "no");
        }
        #endregion

        #region Fifteenth
        /*
         * For Loop & For-Each Lopp
         * Its similar to while loop, But the key difference is that we do the initialization at one place,
         * condition check at another place, and modifying the variable at another place, where as for loop
         * has all of these at one place
         * 
         * For-Each loop is used to iterate through the items of a collection.
         * Always use for loop when you know the array won't be modified or the length remains constant
         * Use foreach if you feel the array or list keeps modifying
         */
        public void fifteenth()
        {
            for(int i=0; i<5; i++)
            {
                Console.WriteLine(i);
            }

            int[] Numbers = new int[3];
            Numbers[0] = 35;
            Numbers[1] = 53;
            Numbers[2] = 35;

            for(int i=0; i<Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }

            foreach(int j in Numbers)
            {
                Console.WriteLine(j);
            }

            //Break and continue;
            //Break is used when you want to come out of the loop and move to next line of code
            //Continue is used when you want to skip that particular iteration
        }
        #endregion

        #region Sixteenth
        /*
         * Methods/Functions
         * 
         * [attributes]
         * access-modifiers return-type medthod-name(parameters)
         * {
         *      Method Body
         * }
         * 
         * Methods with static keyword are called static methods.
         * Methods without static keyword are called instance methods.
         */
        public void sixteenth()
        {
            //creating object of Intoduction class
            Introduction intro = new Introduction();
            //Calling Instance method. Instance method is invoked using the class object.
            intro.evenNumbers(30);
            //Calling Static method. Static method is invoked using the class name.
            Introduction.oddNumbers(20);
            //Calling add method inside the writeline method
            Console.WriteLine(add_numbers(3, 5));
        }

        public void evenNumbers(int num_passed)
        {
            for(int i=0; i<num_passed; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void oddNumbers(int num_passed)
        {
            for (int i = 1; i < num_passed; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public int add_numbers(int a, int b)
        {
            return a + b;
        }
        #endregion

        #region Seventeenth
        /*
         * Method Parameters
         * 
         * Pass by value: 
         * Operations handled on one variable will not affect the value of other variable.
         * 
         * Pass by reference: 
         * Operations handled on one variable will affect the value of other variable.
         * 
         * Value Parameters : 
         * Creates a copy of the parameter passed, so modifications does not affect each other
         *
         *Reference Parameters: 
         *The ref method parameter keyword on a method parameter causes a method to refer 
         *to the same variable that was passed into the method. Any changed made to the parameter in the method 
         *will be reflected in that variable when control passes back to the calling method.
         *
         *Out Parameters: Use when you want a method to return more than one value.
         *
         *Parameter arrays: The params keyword lets you specify a method parameter that takes a 
         *variable number of arguments. You can send a comma-separated list of arguments, or an
         *array, or no arguments. Params keyword should be the last one in a method declaration,
         *and only one params keyword is permitted in method declaration.
         */
        public void seventeenth()
        {
            int i = 0;
            //In this case i and j are pointig to different memory locations
            SimpleMethod(i);
            Console.WriteLine(i);//0
            //In this case i and j are pointig to the same memory locations as we are using pass by reference
            SimpleMethod1(ref i);
            Console.WriteLine(i);//105

            //Out paramaters
            int sum = 0;
            int product = 0;
            calculate_sum_prod(3, 5, out sum, out product);
            Console.WriteLine("sum: {0}, product: {1}", sum, product);

            //Params method
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;


            //By using the params keyword, you can specify a method parameter that takes a variable number of arguments.The parameter type must be a single - dimensional array.

            //No additional parameters are permitted after the params keyword in a method declaration, and only one params keyword is permitted in a method declaration.

            //If the declared type of the params parameter is not a single - dimensional array, compiler error CS0225 occurs.

            //When you call a method with a params parameter, you can pass in:

            //A comma-separated list of arguments of the type of the array elements.
            //An array of arguments of the specified type.
            //No arguments. If you send no arguments, the length of the params list is zero.
            //It is useful when programmer don't have any prior knowledge about the number of parameters to be used.

            //paramsMethod();
            //paramsMethod(Numbers);
            paramsMethod(1, 2, 3, 4, 5);
        }

        public static void SimpleMethod(int j)
        {
            j = 101;
        }

        public static void SimpleMethod1(ref int j)
        {
            j = 105;
        }

        public static void calculate_sum_prod(int a, int b, out int s, out int p)
        {
            s = a + b;
            p = s * b;
        }

        public static void paramsMethod(params int[] nums)
        {
            Console.WriteLine("There are {0} elements", nums.Length);

            foreach(int j in nums)
            {
                Console.WriteLine(j);
            }
        }
        #endregion

        #region Eighteenth
        /*
         * Namespaces
         * 
         * Namespaces are used in organizing your programs.
         * They also provide assistance in avoiding name clashes.
         * 
         * 
         */
        public void eighteenth()
        {
            //We can use eithe fully qualified name as shown below or use using directive ProjectA.TeamA
            //ProjectA.TeamA.ClassA.printA();
            //ProjectA.TeamB.ClassA.printA();

            //ClassA.printA(); This line throws error due to abmbiguity in referencing.
            //To avoid ambiguous reference there are 2 solutions 
            //one is using fully qualified names and the other is using alises
            PATA.ClassA.printA();
            PATB.ClassA.printA();

            //Namespaces don't correspond to any file, directory or assembly names. They could be written in seperate files 
            //and/or seperated assemblies and still belong to the same namespace.

            //Namespaces can be nested in 2 ways
            //Namespace alias directives. Sometimes you may encounter a long namespace and wish to have it shorter. 
            //This could improve readability and still avoid nameclashes.

            /*
             * namespace ProjectA.TeamA
             * {
             * }
             * 
             * or 
             * 
             * namespace ProjectA
             * {
             *      namespace TeamA
             *      {
             *      }
             * }
             */
        }
        #endregion

        #region Nineteenth
        /*
         * Class
         * 
         * To create custom types we create classes
         * A class consists of data and behavior. Class data is represented by it's fields 
         * and behavior is represented by it's fields and behavior is represented by its methods 
         * 
         *Purpose of a constructor is to initialize the class fields. A class constructor is automatically called 
         *when an instance of a class is created.
         *By default there will be parameterless constructor even if we don't initialize one
         *If there is a constructor with n parameters then you must pass those number of values while creating the object
         *Constructors can be overloaded by the number of parameters
         *Constructors do not have a return values and have the same name as that of the class
         */
        public void nineteenth()
        {
            Customer c1 = new Customer("Lakshmi Kesava Reddy", "Indla");
            c1.printName();

            Customer c2 = new Customer();
            c2.printName();
        }
        #endregion

        #region Twentieth
        /*
         * Static and Instance class members
         * 
         * When a class member includes a static modifier, the member is called as static member:
         *When no static modifier is present the member is called as non static member or instance member.
         *
         *Static members are invoked using class name, where as instance members are invoked using instances(objects) of the class.
         *
         *An instance member belongs to specific instance(object) of a class. If I create 3 objects of a class, 
         *I will have 3 sets of instance members in the memory, where as there will ever be 
         *Only one copy of a static member, no matter how ipany instances of a class are created.
         *
         *Note: Class members = fields, methods, properties, events, indexers, constructors.
         *
         *Static constructors are used to instantiate static fields in a class
         *Static constructors are called before an instance constructors
         */
        public void twentieth()
        {
            Circle c1 = new Circle(5);
            Console.WriteLine(c1.calculateArea());

            Circle c2 = new Circle(6);
            Console.WriteLine(c2.calculateArea());
        }
        #endregion

        #region Twentyfirst
        /*
         * TwentyFirst
         * 
         * Check the screenshots
         * But regarding Base ketyword
         *The base keyword is used to access members of the base class from within a derived class:
         *1. Specify which base-class constructor should be called when creating instances of the derived class
         *2: Call a method on the base class that has been overridden by another method.
         *
         *It is an error to use the base keyword from within a static method.
         */
        public void twentyFirst()
        {
            FullTimeEmployee fte1 = new FullTimeEmployee();
            fte1.FirstName = "Lakshmi";
            fte1.LastName = "Indla";
            fte1.Email = "indlakesava@gwu.edu";
            fte1.PrintFullName();
        }
        #endregion

        #region TewntySecond
        public void twentySecond()
        {
            PartTimeEmployee22 pte22_1 = new PartTimeEmployee22();
            pte22_1.FirstName = "Part time";
            pte22_1.LastName = "employee";
            pte22_1.PrintFullName();
            //Calling the hidden method using the base class type using cast
            ((Employee22)pte22_1).PrintFullName();

            //Or use the parent class reference variable and assign child class object to it.
            Employee22 pte22_2 = new PartTimeEmployee22();
            pte22_2.FirstName = "Part time";
            pte22_2.LastName = "employee";
            pte22_2.PrintFullName();

            //We cannot do 
            //PartTimeEmployee22 pte22_3 = new Employee22();
            //Because derivede class have items of both parent and its own but, parent object
            //cannot fulfill/fill all the items of derived class
            FullTimeEmployee22 fte22_1 = new FullTimeEmployee22();
            fte22_1.FirstName = "Full time";
            fte22_1.LastName = "employee";
            fte22_1.PrintFullName();
        }
        #endregion

        #region TwentyThird
        public void twentyThird()
        {
            Employee23[] employee23s = new Employee23[4];

            employee23s[0] = new Employee23();
            employee23s[1] = new PartTimeEmployee23();
            employee23s[2] = new FullTimeEmployee23();
            employee23s[3] = new TempTimeEmployee23();

            foreach(Employee23 e in employee23s)
            {
                e.PrintFullName();
            }
        }
        #endregion

        #region TwentyFour
        /*
         * Method overriding vs method hiding
         */
        public void twentyFour()
        {
            BaseClass24 baseClass24 = new DerivedClass24();
            baseClass24.print();
        }
        #endregion

        #region TwentyFive
        /*
         * Method overloading - Having same method name but differ in 
         * 1. Number of paramaters
         * 2. Datatypes of parameters (int, float, etc.,)
         * 3. Kind of parameters (value, out, ref)
         * 
         * Function cannot be oerloaded based on return type as method signature is not formed based on return type
         * 
         * It's not possible to just overload functions based on params keyword.
         * Because sometime there can be empty params input in which case the system gets confused between the methods.
         */
        public void add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum is: " + sum);
        }

        public void add(float a, float b)
        {
            float sum = a + b;
            Console.WriteLine("Sum is: " + sum);
        }
        #endregion
    }

    #region Nineteenth
    class Customer
    {
        string _firstName;
        string _LastName;

        public Customer() : this("No first name provided", "No last name provided")
        {   
        }

        //Customer method below is the constructor
        public Customer(string f_name, string l_name)
        {
            this._firstName = f_name;
            this._LastName = l_name;
        }

        public void printName()
        {
            Console.WriteLine("Full Name is:"+this._firstName+ ", " + this._LastName);
        }

        //Usually destructors are used to cleanup the resources used, but in C# you don't need them.
        //Destructors have ~ symbol infront of the method name.
        //They don't take any parameters as well as they don't retutn any value
        //They are usually called when the garbage collector decide to clean your object from memory.
        ~Customer()
        {
            //Clean up code
        }
    }
    #endregion

    #region Twentieth
    class Circle
    {
        //If _PI is not static means instance field then its copy is created whenever a new object is created.
        //If PI is static then only one instance is created
        //float _PI = 3.141F;
        static float _PI = 3.141F;
        int _Radius;

        public Circle (int Radius)
        {
            this._Radius = Radius;
        }

        public float calculateArea()
        {
            return 2 * _PI * _Radius * _Radius;
        }
    }
    #endregion

    #region TwentyFirst
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public Employee()
        {
            Console.WriteLine("Employee class - Parent class");
        }
        public Employee(string message)
        {
            Console.WriteLine("Employee class - Parent class with message parameter");
        }

        public void PrintFullName()
        {
            Console.WriteLine("I am " + FirstName + ", " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee() : base("We are calling the second constructor with 1 parameter")
        {
            Console.WriteLine("Full Time Employee class - Child Class");
        }

        float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        float HourlyRate;
    }
    #endregion

    #region TewntySecond
    public class Employee22
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine("Base - I am " + FirstName + ", " + LastName);
        }
    }

    public class FullTimeEmployee22 : Employee22
    {
        public void PrintFullName()
        {
            base.PrintFullName();
        }
    }

    public class PartTimeEmployee22 : Employee22
    {
        //This method shows warning: "Use new keyword if hiding was intended". Eventhough it works.
        //public void PrintFullName()
        //{
        //    Console.WriteLine("I am " + FirstName + ", " + LastName + "*");
        //}

        //Buit why is new keyword used while hiding???
        //Actually when 2 people are working on a project and one have written the base class
        //and now you are writting the derived class now then you should be wanrned that there is already
        //a method which have the same name in the base class and if it is not intentional then
        //change the name of this new method or else then add the new keyword so that it makes sense of method hiding
        public new void PrintFullName()
        {
            Console.WriteLine("I am " + FirstName + ", " + LastName + "*");
        }
    }
    #endregion

    #region TwentyThird
    public class Employee23
    {
        public string firstName = "FN";
        public string lastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PartTimeEmployee23 : Employee23
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + "PartTime");
        }
    }

    public class FullTimeEmployee23 : Employee23
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + "FullTime");
        }
    }

    public class TempTimeEmployee23 : Employee23
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + "Temp");
        }
    }
    #endregion

    #region TwentyFour
    public class BaseClass24
    {
        //Method overriding
        //public virtual void print()
        //{
        //    Console.WriteLine("I am a base class print method");
        //}

        //Method overloading
        public void print()
        {
            Console.WriteLine("I am a base class print method");
        }
    }

    public class DerivedClass24 : BaseClass24
    {
        //Method overriding
        //public override void print()
        //{
        //    Console.WriteLine("I am a derived class print method");
        //}

        //Method hiding
        public new void print()
        {
            Console.WriteLine("i am a derived class print method");
        }
    }
    #endregion
}


#region Tutorial-18 Namespaces
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void printA()
            {
                Console.WriteLine("Team A print method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void printA()
            {
                Console.WriteLine("Team B print method");
            }
        }
    }
}
#endregion