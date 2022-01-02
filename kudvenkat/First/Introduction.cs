using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
using System.Runtime.Serialization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Linq;

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
            Console.WriteLine(num1 + num2 * num1 - num2 / num1);
            //Comparision Operator ==, !=, >, >=, <, <=
            if (num1 >= num2 && num1 <= num2)
            {
                Console.WriteLine(true);
            }
            //Conditional Operator &&, ||
            //Ternary Operator ?:
            Console.WriteLine(num1 < num2 ? true : false);
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
            if (AreYouMajor == true)
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

            if (ticketsonsalee == null)
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
            if (userInput != 1 && userInput != 2 && userInput != 3)
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

            while (start <= target)
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
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] Numbers = new int[3];
            Numbers[0] = 35;
            Numbers[1] = 53;
            Numbers[2] = 35;

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }

            foreach (int j in Numbers)
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
            for (int i = 0; i < num_passed; i += 2)
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

            foreach (int j in nums)
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
        /*
         * Method Hiding
         */
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
        /*
         * Polymorphism
         */
        public void twentyThird()
        {
            Employee23[] employee23s = new Employee23[4];

            employee23s[0] = new Employee23();
            employee23s[1] = new PartTimeEmployee23();
            employee23s[2] = new FullTimeEmployee23();
            employee23s[3] = new TempTimeEmployee23();

            foreach (Employee23 e in employee23s)
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

        #region TwentySix
        /*
         * Properties - getter and setter methods before properties
         */
        public void twentySix()
        {
            Student26 s26 = new Student26();
            s26.SetId(5);
            Console.WriteLine(s26.GetId());
        }
        #endregion

        #region TwentySeven
        /*
         * Properties
         */
        public void twentySeven()
        {
            Student27 s27 = new Student27();
            s27.id = 5;
            Console.WriteLine(s27.id);
        }
        #endregion

        #region TwentyEight
        /*
         * Structs
         */
        public void twentyEight()
        {
            Customer28 c28_1 = new Customer28(1, "Lakshmi");
            c28_1.printDetails();

            Customer28 c28_2 = new Customer28();
            c28_2.id = 2;
            c28_2.name = "Kesava";
            c28_2.printDetails();

            Customer28 c28_3 = new Customer28
            {
                id = 3,
                name = "Indla"
            };
            c28_3.printDetails();
        }
        #endregion

        #region TwentyNine
        /*
         * Class vs Struct
         * https://www.dotnetodyssey.com/2014/06/06/beginners-guide-value-reference-types-c/
         */
        public void twentyNine()
        {
            Console.WriteLine("Check the Images doc");
        }
        #endregion

        #region Thirty
        /*
         * Interfaces
         */
        public void thirty()
        {
            Customer_30 c_30 = new Customer_30();
            c_30.print1();
            c_30.print2();

            //We cannot create an instance of an interface, but an interface reference variable can point to 
            //a derived class object
            ICustomer30 ic_30 = new Customer_30();
            ic_30.print1();
        }
        #endregion

        #region ThirtyOne
        /*
         *Explicit Interface Implementation 
         */
        public void thirtyOne()
        {
            Program_31 program_31 = new Program_31();
            ((I31_1)program_31).interfaceMethod31();
            ((I31_2)program_31).interfaceMethod31();

            I31_1 i31_1 = new Program_31();
            I31_2 i31_2 = new Program_31();
            i31_1.interfaceMethod31();
            i31_2.interfaceMethod31();

            //Default Method 
            program_31.interfaceMethod31();
        }
        #endregion

        #region ThirtyTwo
        /*
         * Since abstract classes are incomplete we cannot create an instance of such classes
         * and they can only act as base classes for other classes
         */
        public void thirtyTwo()
        {
            Program_32 program_32 = new Program_32();
            program_32.print();
        }
        #endregion

        #region ThirtySix
        /*
         * A delegate is a type safe function pointer
         */
        public void thirtySix()
        {
            HelloFuncDelegate36 helloFuncDelegate = new HelloFuncDelegate36(Hello);
            helloFuncDelegate("call from Delegate");

            Hello("Direct call of method");
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
        #endregion

        #region ThirtySeven
        //Showing how it would be restricting without delegates
        public void thirtySeven()
        {
            List<Employee37> empList = new List<Employee37>();
            empList.Add(new Employee37() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee37() { Id = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee37() { Id = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee37() { Id = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            Employee37.promoteEmployee(empList);
        }
        #endregion

        #region ThirtyEight
        //Demo of previous problem Using daalegates
        public void thirtyEight()
        {
            List<Employee38> empList = new List<Employee38>();
            empList.Add(new Employee38() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee38() { Id = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee38() { Id = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee38() { Id = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            //Employee38.promoteEmployee(empList, promoteEmployee38);
            //Lambda expressions
            Employee38.promoteEmployee(empList, emp => emp.Experience >= 5);
        }

        public bool promoteEmployee38(Employee38 employee38)
        {
            if (employee38.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region ThirtyNine 
        /*
         * Multicast Delegates
         */
        public void thirtyNine()
        {
            SampleDelegate39 delegate39_1, delegate39_2, delegate39_3, delegate39_4;

            delegate39_1 = new SampleDelegate39(sampleMethod39_1);
            //delegate39_2 = new SampleDelegate39(smapleMethod39_2);
            //delegate39_3 = new SampleDelegate39(smapleMethod39_3);

            ////Multicast delegate - delegate pointing to more than one function
            //delegate39_4 = delegate39_1 + delegate39_2 + delegate39_3 - delegate39_2;
            //delegate39_4();

            delegate39_1 += sampleMethod39_2;
            delegate39_1 += sampleMethod39_3;
            delegate39_1 -= sampleMethod39_2;
            delegate39_1();
        }

        public static void sampleMethod39_1()
        {
            Console.WriteLine("Sample Method 1 Invoked");
        }

        public static void sampleMethod39_2()
        {
            Console.WriteLine("Sample Method 2 Invoked");
        }

        public static void sampleMethod39_3()
        {
            Console.WriteLine("Sample Method 3 Invoked");
        }
        #endregion

        #region Fourty
        /*
         * Exception Handling
         */
        public void fourty()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader("../text.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally Block");
            }
        }
        #endregion

        #region FourtyOne
        /*
         * Inner Exceptions
         */
        public void fourtyOne()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number:");
                    int fn = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number:");
                    int sn = Convert.ToInt32(Console.ReadLine());

                    int result = fn / sn;
                    Console.WriteLine("Result={0}", result);
                }
                catch (Exception ex)
                {
                    string filepath = @"C:\Kesava\Practice\CSharp\kudvenkat\kudvenkat\First\log1.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter streamWriter = new StreamWriter(filepath);
                        streamWriter.WriteLine(ex.GetType());
                        streamWriter.WriteLine(ex.Message);
                        streamWriter.Close();
                        Console.WriteLine("There is an exception");
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + " is not present", ex);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Current Exception = {0}", exc.GetType().Name);
                if (exc.InnerException != null)
                {
                    Console.WriteLine("Inner Exception = {0}", exc.InnerException.GetType().Name);
                }
            }
        }
        #endregion

        #region FourtyTwo
        /*
         * Custom Exceptions
         */
        public void fourtyTwo()
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is already logged in- no duplicate session allowed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region FourtyThree
        /*
         * Exception Handling Abuse
         */
        public void fourtyThree()
        {
            try
            {
                Console.WriteLine("Please enter a numerator");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter a denominator");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine("Result={0}", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter numbers only between {0} and {1}", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
        }
        #endregion

        #region FourtyFour
        /*
         * Preventing Exception Handling Abuse
         */
        public void fourtyFour()
        {
            try
            {
                Console.WriteLine("Please enter a numerator");
                int numerator;
                bool isNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out numerator);

                if (isNumeratorConversionSuccessful)
                {
                    Console.WriteLine("Please enter a denominator");
                    int denominator;
                    bool isDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out denominator);

                    if (isDenominatorConversionSuccessful && denominator != 0)
                    {
                        int result = numerator / denominator;
                        Console.WriteLine("Result={0}", result);
                    }
                    else
                    {
                        if (denominator == 0)
                        {
                            Console.WriteLine("Denominator cannot be zero");
                        }
                        else
                        {
                            Console.WriteLine("Enter numbers only between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter numbers only between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter numbers only between {0} and {1}", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
        }
        #endregion

        #region FourtyFive
        /*
         * Why Enums
         */
        public void fourtyFive()
        {
            Customer45[] customer45s = new Customer45[3];

            customer45s[0] = new Customer45
            {
                Name = "Mark",
                Gender = 0
            };
            customer45s[1] = new Customer45
            {
                Name = "Marry",
                Gender = 1
            };
            customer45s[2] = new Customer45
            {
                Name = "Sam",
                Gender = 2
            };

            foreach (Customer45 c in customer45s)
            {
                Console.WriteLine("Name={0} and Gender={1}", c.Name, getGender45(c.Gender));
            }
        }

        public static string getGender45(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Male";
                case 1:
                    return "Female";
                case 2:
                    return "Unknown";
                default:
                    return "Invalid data detected";
            }
        }
        #endregion

        #region FourtySix
        /*
         * Enums Example
         */
        public void fourtySix()
        {
            Customer46[] customer46s = new Customer46[3];

            customer46s[0] = new Customer46
            {
                Name = "Mark",
                Gender = Gender46.Male
            };
            customer46s[1] = new Customer46
            {
                Name = "Marry",
                Gender = Gender46.Female
            };
            customer46s[2] = new Customer46
            {
                Name = "Sam",
                Gender = Gender46.Unknown
            };

            foreach (Customer46 c in customer46s)
            {
                Console.WriteLine("Name={0} and Gender={1}", c.Name, getGender46(c.Gender));
            }
        }

        public static string getGender46(Gender46 gender)
        {
            switch (gender)
            {
                case Gender46.Male:
                    return "Male";
                case Gender46.Female:
                    return "Female";
                case Gender46.Unknown:
                    return "Unknown";
                default:
                    return "Invalid data detected";
            }
        }
        #endregion

        #region FourtySeven
        /*
         * Enums
         */
        public void fourtySeven()
        {
            short[] values = (short[])Enum.GetValues(typeof(Gender47));
            foreach (short i in values)
            {
                Console.WriteLine(i);
            }

            string[] names = (string[])Enum.GetNames(typeof(Gender47));
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
        }
        #endregion

        #region FiftyTwo
        /*
         * Attributes
         */
        public void fiftyTwo()
        {
            Calculator52 calculator52 = new Calculator52();
            Console.WriteLine(calculator52.Add(1, 2));
            //Console.WriteLine(calculator52.Add_dont_use(1, 2));
            Console.WriteLine(calculator52.Addm(1, 2, 3, 4));
        }
        #endregion

        #region FiftyThree
        /*
         * Reflection
         */
        public void fiftyThree()
        {
            //Type T = Type.GetType("kudvenkat.First.Customer53");
            //Type T = typeof(Customer53);
            Customer53 c53 = new Customer53();
            Type T = c53.GetType();
            PropertyInfo[] propertyInfos = T.GetProperties();

            Console.WriteLine("Properties in the Customer53 class");
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Console.WriteLine(propertyInfo.PropertyType.Name + " " + propertyInfo.Name);
            }

            Console.WriteLine("Methods in the Customer53 class");
            MethodInfo[] methodInfos = T.GetMethods();
            //you get 10 methods instead of 2. They are getId, setId, getName, setName from the properties
            //and the 2 methods from the class itself. Finally 4 methods from the object class.
            //So by default every type directly or indirectly inherits from System.Object.
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.ReturnType.Name + " " + methodInfo.Name);
            }
        }
        #endregion

        #region FiftyFive
        /*
         * Late Binding using Reflection
         */
        public void fiftyFive()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("kudvenkat.First.Customer55");
            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullNameMethod = customerType.GetMethod("getFullName");

            string[] parameters = new string[2];
            parameters[0] = "Lakshmi";
            parameters[1] = "Indla";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name = {0}", fullName);
        }
        #endregion

        #region FiftySix
        /*
         * Generics - makes the code type independent
         */
        public void fiftySix()
        {
            Calculator56 calculator56 = new Calculator56();
            Console.WriteLine(calculator56.AreEqual("A", "B"));//False
            Console.WriteLine(calculator56.AreEqual("A", "A"));//True
            Console.WriteLine(calculator56.AreEqual(1, 1));//False
            Console.WriteLine(calculator56.AreEqual("1", 1));//False
            //In the above case when we pass 1,1 we get false. Here 1 is an integer which is a structure,
            //Structure is a value type. At runtime this value type needs to be converted into object type
            //or refernence type which is called boxing. Boxing is happenning unnecessarily just to compare.
            //Because of unnecessary boxing and unboxing the performance is degraded.
            //Also it allows to enter 2 different types to compare which can be stopped at compile time itself.
            //The best way to make the method AreEqual independent of the datatype is to use Generics.
            Console.WriteLine(calculator56.AreEqualUsingGenerics<String>("A", "B"));//False
            Console.WriteLine(calculator56.AreEqualUsingGenerics<string>("A", "A"));//True
            Console.WriteLine(calculator56.AreEqualUsingGenerics<int>(1, 1));//True

            Calculator56_1<int> calculator56_1 = new Calculator56_1<int>();
            //Console.WriteLine(calculator56_1.AreEqualUsingGenerics("A", "B"));//Compilation Error
            //Console.WriteLine(calculator56_1.AreEqualUsingGenerics("A", "A"));//Comilation Error
            Console.WriteLine(calculator56_1.AreEqualUsingGenerics(1, 1));//True
        }
        #endregion

        #region FiftySeven
        /*
         * Why should we override ToString method
         */
        public void fiftySeven()
        {
            int Num = 10;
            Console.WriteLine(Num.ToString());//10

            Customer57 customer57 = new Customer57();
            customer57.firstName = "Lakshmi";
            customer57.lastName = "Indla";

            //Default implementation of ToString by the base class gives the complete name of the type including the namespace
            //If you want to modify the implementation then you need to override the ToString method
            //Every type inherits from the base class System.Object, and it provides 4 methods and out of them we can override 3 out of them.
            Console.WriteLine(customer57.ToString());//kudvenkat.First.Customer57
        }
        #endregion

        #region FiftyEight
        /*
         * Why should we override Equals method
         * 
         * In our class if we override the Equals method then its recommended to override GetHashCode method too
         */
        public void fiftyEight()
        {
            int i = 10;
            int j = 10;

            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));

            Directions58 d1 = Directions58.East;
            Directions58 d2 = Directions58.West;
            Directions58 d3 = Directions58.East;

            Console.WriteLine(d1.Equals(d2));
            Console.WriteLine(d1.Equals(d3));

            Customer58 customer58_1 = new Customer58();
            customer58_1.firstName = "Lakshmi";
            customer58_1.lastName = "Indla";

            Customer58 customer58_2 = new Customer58();
            customer58_2.firstName = "Hoger";
            customer58_2.lastName = "Trace";

            Customer58 customer58_3 = new Customer58();
            customer58_3.firstName = "Lakshmi";
            customer58_3.lastName = "Indla";

            Customer58 customer58_4 = customer58_1;


            Console.WriteLine(customer58_1.Equals(customer58_2));//False -after implementation False
            Console.WriteLine(customer58_1.Equals(customer58_3));//False -after implementation True
            Console.WriteLine(customer58_1.Equals(customer58_4));//True -after implementation True
        }
        #endregion

        #region FiftyNine
        /*
         * Convert.Tostring() vs ToString()
         * 
         * Depending on the application we use them accordingly
         * If we want to throw an erroe/Exception when the object set to null use ToString()
         * When we don't want an exception then use Convet.ToString (Example web application forms)
         */
        public void fiftyNine()
        {
            Customer59 customer59_1 = new Customer59();
            Customer59 customer59_2 = null;
            Console.WriteLine(customer59_1.ToString());
            Console.WriteLine(Convert.ToString(customer59_1));
            //Console.WriteLine(customer59_2.ToString()); //Throws NullReferenceException
            Console.WriteLine(Convert.ToString(customer59_2));
        }
        #endregion

        #region Sixty
        /*
         * String vs StringBuilder
         */
        public void sixty()
        {
            String s = "C#";
            s += " Video";
            s += " Tutorial";
            s += " For";
            s += " Beginners";
            Console.WriteLine(s);

            StringBuilder sb = new StringBuilder("C#");
            sb.Append(" Video");
            sb.Append(" Tutorial");
            sb.Append(" For");
            sb.Append(" Beginners");
            Console.WriteLine(sb);
        }
        #endregion

        #region SixtyOne
        /*
         * Partial Classes
         */
        public void sixtyOne()
        {
            Customer61 customer61 = new Customer61();
            customer61.FirstName = "Lakshmi";
            customer61.LastName = "Indla";
            Console.WriteLine(customer61.getFullName());
        }
        #endregion

        #region SixtyThree
        public void sixtyThree()
        {
            SamplePartialClass63 samplePartialClass63 = new SamplePartialClass63();
            samplePartialClass63.PublicMethod();//This method runs even without implementation of the partial method in it.

        }
        #endregion

        #region SixtyFour
        /*
         * Indexers - Used to store and retrieve data from session state or application state variables.
         * Just like properties indexers have get and set accessors
         * 
         * protected void Page_Load(object sender, EventArgs e)
         * {
         *      Session["session1"] = "Session 1 Data";
         *      Session["session2"] = "Session 2 Data";
         *      
         *      Response.Write("Session 1 Data: " + Session[0]) // Session 1 Data: Session 1 Data
         *      Response.Write("Session 2 Data: " + Session["Session2"]) // Session 2 Data: Session 2 Data
         * }
         */

        public void sixtyFour()
        {

        }
        #endregion

        #region SixtySeven
        /*
         * Optional Parameters - using params
         */
        public void sixtySeven()
        {
            AddNumbers67(10, 20);
            AddNumbers67(15, 50, new object[] { 3, 5, 8 });
        }

        public static void AddNumbers67(int fn, int sn, params object[] restOfNumbers)
        {
            int result = fn + sn;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Sum = {0}", result);
        }
        #endregion

        #region SixtyEight
        /*
         * Optional parameters - using method overloading
         */
        public void sixtyEight()
        {
            AddNumbers68(10, 20);
            AddNumbers68(10, 20, new object[] { 30, 40 });
        }

        public static void AddNumbers68(int fn, int sn)
        {
            AddNumbers68(fn, sn, null);
        }

        public static void AddNumbers68(int fn, int sn, params object[] restOfNumbers)
        {
            int result = fn + sn;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Sum = {0}", result);
        }
        #endregion

        #region SixtyNine
        /*
         * Optional parameters - using parameter defaults
         */
        public void sixtyNine()
        {
            AddNumbers69(10, 20);
            AddNumbers69(10, 20, new int[] { 30, 40 });

            DisplayNumbersDefault69(10);
            DisplayNumbersDefault69(10, 8);
            DisplayNumbersDefault69(10, 8, 15);
        }

        public static void AddNumbers69(int fn, int sn, int[] restOfNumbers = null)
        {
            int result = fn + sn;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Sum = {0}", result);
        }

        public static void DisplayNumbersDefault69(int a, int b = 20, int c = 30)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        #endregion

        #region Seventy
        /*
         * Optional parameters - using OptionalAttribute
         */
        public void seventy()
        {
            AddNumbers70(10, 20);
            AddNumbers70(10, 20, new int[] { 30, 40 });
        }

        public static void AddNumbers70(int fn, int sn, [OptionalAttribute] int[] restOfNumbers)
        {
            int result = fn + sn;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Sum = {0}", result);
        }
        #endregion

        #region SeventyTwo
        /*
         * Dictionary
         * Both tutorials 72, 73
         */
        public void seventyTwo()
        {
            // Create a Dictionary, CustomerID is the key. Type is int
            // Customer object is the value. Type is Customer
            Dictionary<int, Customer72> dictionaryCustomers = new Dictionary<int, Customer72>();

            // Create Customer Objects
            Customer72 customr1 = new Customer72()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer72 customr2 = new Customer72()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer72 customr3 = new Customer72()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };

            // Add customer objects to the dictionary
            dictionaryCustomers.Add(customr1.ID, customr1);
            dictionaryCustomers.Add(customr2.ID, customr2);
            dictionaryCustomers.Add(customr3.ID, customr3);

            // Retrieve the value (Customer object) from the dictionary,
            // using key (customer ID). The fastest way to get a value
            // from the dictionary is by using its key
            Console.WriteLine("Customer 101 in customer dictionary");
            Customer72 customer101 = dictionaryCustomers[101];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                            customer101.ID, customer101.Name, customer101.Salary);
            Console.WriteLine("--------------------------------------------------");

            // It is also possible to loop thru each key/value pair in a dictionary
            Console.WriteLine("All customer keys and values in customer dictionary");
            foreach (KeyValuePair<int, Customer72> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                Customer72 cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            Console.WriteLine("--------------------------------------------------");

            // You can also use implicitly typed variable VAR to 
            // loop thru each key/value pair in a dictionary. But try
            // to avoid using var, as this makes your code less readable
            Console.WriteLine("All customer keys and values in customer dictionary");
            foreach (var customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                Customer72 cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            Console.WriteLine("--------------------------------------------------");

            // To get all the keys in the dictionary
            Console.WriteLine("All Keys in Customer Dictionary");
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("--------------------------------------------------");

            // To get all the values in the dictionary
            Console.WriteLine("All Customer objects in Customer Dictionary");
            foreach (Customer72 customer in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }

            // If you try to add a key that already exists in the dictionary you 
            // will get an exception - An item with same key has already been 
            // added. So, check if the key already exists
            if (!dictionaryCustomers.ContainsKey(101))
            {
                dictionaryCustomers.Add(101, customr1);
            }

            // When accessing a dictionary value by key, make sure the dictionary 
            // contains the key, otherwise you will get KeyNotFound exception.
            if (dictionaryCustomers.ContainsKey(110))
            {
                Customer72 cus = dictionaryCustomers[110];
            }
            else
            {
                Console.WriteLine("Key does not exist in the dictionary");
            }

            // If you are not sure if a key is present or not, you can use 
            // TryGetValue() method to get the value from a dictionary.
            Customer72 customer999;
            if (dictionaryCustomers.TryGetValue(999, out customer999))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer999.ID, customer999.Name, customer999.Salary);
            }
            else
            {
                Console.WriteLine("Customer with Key = 999 is not found in the dictionary");
                Console.WriteLine("-------------------------------------------------------------------");
            }

            // To find the total number of items in a dictionary use Count() method
            Console.WriteLine("Total items in Dictionary = {0}", dictionaryCustomers.Count());

            Console.WriteLine("-------------------------------------------------------------------");

            // LINQ extension methods can be used with Dictionary. For example, to find the 
            // total employees whose salary is greater than 5000.
            Console.WriteLine("Items in dictionary where Salary is greater than 5000 = {0}",
                dictionaryCustomers.Count(x => x.Value.Salary > 5000));
            Console.WriteLine("-------------------------------------------------------------------");

            // To remove an item from the dictionary, use Remove() method
            dictionaryCustomers.Remove(101);

            // To remove all items from the dictionary, use Clear() method
            dictionaryCustomers.Clear();

            // Create an array of customers
            Customer72[] arrayCustomers = new Customer72[3];
            arrayCustomers[0] = customr1;
            arrayCustomers[1] = customr2;
            arrayCustomers[2] = customr3;

            // Convert customer array to a dictionary using ToDictionary() method.
            // In this example, key is Customer ID and value is the customer object
            Dictionary<int, Customer72> dict = arrayCustomers.ToDictionary(customer => customer.ID, customer => customer);
            // OR        
            // Dictionary<int, Customr> dict = arrayCustomers.ToDictionary(customer => customer.ID);
            // OR use a foreach loop
            // Dictionary<int, Customer> dict = new Dictionary<int, Customer>();
            // foreach (Customer cust in arrayCustomers)
            // {
            //     dict.Add(cust.ID, cust);
            // }

            // Loop thru the dictionary and print the key/value pairs
            foreach (KeyValuePair<int, Customer72> kvp in dict)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Customer72 customr = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary {2}", customr.ID, customr.Name, customr.Salary);
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }
        #endregion

        #region SeventyFour
        /*
         * List Collegetion
         */
        public void seventyFour()
        {
            // Create Customer Objects
            Customer74 customer1 = new Customer74()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer74 customer2 = new Customer74()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer74 customer3 = new Customer74()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };

            Customer74[] arrayCustomers = new Customer74[2];
            arrayCustomers[0] = customer1;
            arrayCustomers[1] = customer2;
            // The following line will throw an exception, Index was outside the bounds of the array. 
            // This is because, arrays does not grow in size automatically.
            // arrayCustomers[2] = customer3;

            // Create a List of Customers. Here, we have set the size to 2. But when I add a third 
            // element the list size will automatically grow and we will not get an exception.
            List<Customer74> listCustomers = new List<Customer74>(2);
            // To add an element to the list, use Add() method.
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            // Adding an element beyond the initial capacity of the list will not throw an exception.
            listCustomers.Add(customer3);

            // Items can be retrieved from the list by index. The following code will 
            // retrieve the first item from the list. List index is ZERO based.
            Customer74 cust = listCustomers[0];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                     cust.ID, cust.Name, cust.Salary);
            Console.WriteLine("------------------------------------------------");

            // foreach or for loop can be used to iterate thru all the items in the list
            // Using for loop
            for (int i = 0; i < listCustomers.Count; i++)
            {
                Customer74 customer = listCustomers[i];
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                         customer.ID, customer.Name, customer.Salary);
            }
            Console.WriteLine("------------------------------------------------");

            // Using foreach loop
            foreach (Customer74 c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------");

            // All generic collection classes including List are strongly typed. This means 
            // if you have created a List of type Customer, only objects of type Customer 
            // can be added to the list. If you try to add an object of different type you would 
            // get a compiler error. The following line will raise a compiler error.
            // listCustomers.Add("This will not compile");

            // If you want to insert an item at a specific index location of the list, use Insert() method. 
            // The following line will insert customer3 object at index location 1.
            //listCustomers.Insert(1, customer3);
            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
            //       listCustomers[1].ID, listCustomers[1].Name, listCustomers[1].Salary);
            //Console.WriteLine("------------------------------------------------");

            // To get the index of specific item in the list use Indexof() method
            Console.WriteLine("Index of Customer3 object in the List = " +
                    listCustomers.IndexOf(customer3));
            Console.WriteLine("------------------------------------------------");

            Customer74[] arrayAllCustomers = listCustomers.ToArray();
            foreach (Customer74 c in arrayAllCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            // To convert a List to a Dictionary use ToDictionary() method
            Dictionary<int, Customer74> dictionaryCustomers = listCustomers.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int, Customer74> keyValuePairCustomers in dictionaryCustomers)
            {
                Console.WriteLine("Key = {0}", keyValuePairCustomers.Key);
                Customer74 c = keyValuePairCustomers.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            // To check if an item exists in the list use Contains() function
            // This method returns true if the items exists, else false
            if (listCustomers.Contains(customer2))
            {
                Console.WriteLine("Customer2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Customer2 object does not exist in the list");
            }
            Console.WriteLine("------------------------------------------------------");

            // To check if an item exists in the list based on a condition, then use Exists() function
            // This method returns true if the items exists, else false
            if (listCustomers.Exists(x => x.Name.StartsWith("M")))
            {
                Console.WriteLine("List contains customer whose name starts with M");
            }
            else
            {
                Console.WriteLine("List does not contain a customer whose name starts with M");
            }
            Console.WriteLine("------------------------------------------------------");

            // Find() method searches for an element that matches the conditions defined by 
            // the specified lambda expression and returns the first matching item from the list
            Customer74 cust1 = listCustomers.Find(customer => customer.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust1.ID, cust1.Name, cust1.Salary);
            Console.WriteLine("------------------------------------------------------");

            // FindLast() method searches for an element that matches the conditions defined
            // by the specified lambda expression and returns the Last matching item from the list
            Customer74 lastMatch = listCustomers.FindLast(customer => customer.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", lastMatch.ID, lastMatch.Name, lastMatch.Salary);
            Console.WriteLine("------------------------------------------------------");

            // FindAll() method returns all the items from the list that
            // match the conditions specified by the lambda expression
            List<Customer74> filteredCustomers = listCustomers.FindAll(customer => customer.Salary > 5000);
            foreach (Customer74 cstmr in filteredCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cstmr.ID, cstmr.Name, cstmr.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            // FindIndex() method returns the index of the first item, that matches the 
            // condition specified by the lambda expression. There are 2 other overloads
            // of this method which allows us to specify the range of elements to 
            // search, with in the list.
            Console.WriteLine("Index of the first matching customer object whose salary is greater 5000 =" +
                listCustomers.FindIndex(customer => customer.Salary > 5000));
            Console.WriteLine("------------------------------------------------------");

            // FindLastIndex() method returns the index of the last item, 
            // that matches the condition specified by the lambda expression. 
            // There are 2 other overloads of this method which allows us to specify 
            // the range of elements to search, with in the list.
            Console.WriteLine("Index of the Last matching customer object whose salary is greater 5000 = " +
                listCustomers.FindLastIndex(customer => customer.Salary > 5000));
            Console.WriteLine("------------------------------------------------------");
        }
        #endregion

        #region SeventySix
        /*
         * Generic List class and ranges
         */
        public void seventySix()
        {
            // Create Customer Objects
            Customer76 customer1 = new Customer76()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
                Type = "RetailCustomer"
            };

            Customer76 customer2 = new Customer76()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,
                Type = "RetailCustomer"
            };

            Customer76 customer3 = new Customer76()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,
                Type = "RetailCustomer"
            };

            Customer76 customer4 = new Customer76()
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "CorporateCustomer"
            };

            Customer76 customer5 = new Customer76()
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "CorporateCustomer"
            };


            List<Customer76> listCustomers = new List<Customer76>();
            // Add() method allows you to add one at a time to the end of the list
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer76> listCorporateCustomers = new List<Customer76>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            // AddRange() allows you to add another list of items, to the end of the list
            listCustomers.AddRange(listCorporateCustomers);

            foreach (Customer76 customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");

            // GetRange() function returns a list of items from the list.
            List<Customer76> corporateCustomers = listCustomers.GetRange(3, 2);
            foreach (Customer76 customer in corporateCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");

            // Remove() function removes only the first matching item from the list.
            listCustomers.Remove(customer1);

            // RemoveAt() function, removes the item at the specified index in the list.
            listCustomers.RemoveAt(0);

            // RemoveAll() function removes all the items that matches the specified condition.
            listCustomers.RemoveAll(x => x.Type == "RetailCustomer");

            foreach (Customer76 customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");

            // RemoveRange() method removes a range of elements from the list.
            // This function expects 2 parameters, i.e the start index in the 
            // list and the number of elements to remove.
            listCustomers.RemoveRange(0, 2);

            // Insert() method allows you to insert a single item at a time into 
            // the list at a specificed index
            listCustomers.Insert(0, customer1);
            listCustomers.Insert(1, customer2);
            listCustomers.Insert(2, customer3);

            // InsertRange() allows you, to insert another list of items to your list at the specified index
            listCustomers.InsertRange(0, listCorporateCustomers);

            foreach (Customer76 customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");

            // If you want to remove all the elements from the list without specifying 
            // any condition, then use Clear() function.
            listCustomers.Clear();

            Console.WriteLine(" Total Items in the List = " + listCustomers.Count);
        }
        #endregion

        #region SeventySeven
        /*
         * Sort a list of simple type
         */
        public void seventySeven()
        {
            List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before sorting");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Sort() will sort data in ascending order 
            numbers.Sort();

            Console.WriteLine("Numbers after sorting");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Use Reverse() method to retrieve data in descending order
            numbers.Reverse();

            Console.WriteLine("Numbers in descending order");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };

            Console.WriteLine("Alphabets before sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Sort();

            Console.WriteLine("Alphabets after sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Reverse();

            Console.WriteLine("Alpabets in descending order");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            Customer77 customer1 = new Customer77()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer77 customer2 = new Customer77()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer77 customer3 = new Customer77()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500
            };

            List<Customer77> listCustomers = new List<Customer77>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine("Customers before sorting");
            foreach (Customer77 customer in listCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            // Invoking Sort() on list of complex types will 
            // throw invalid operation exception, unless 
            // IComparable interface is implemented
            //listCustomers.Sort();

            Console.WriteLine("Customers after sorting");
            foreach (Customer77 customer in listCustomers)
            {
                Console.WriteLine(customer.Name);
            }

        }
        #endregion

        #region SeventyEight
        /*
         * Sorting a list of complex types
         */
        public void seventyEight()
        {
            Customer78 customer1 = new Customer78()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer78 customer2 = new Customer78()
            {
                ID = 102,
                Name = "John",
                Salary = 7000
            };

            Customer78 customer3 = new Customer78()
            {
                ID = 103,
                Name = "Ken",
                Salary = 5500
            };

            List<Customer78> listCutomers = new List<Customer78>();
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);

            Console.WriteLine("Customers before sorting");
            foreach (Customer78 customer in listCutomers)
            {
                Console.WriteLine(customer.Name + " - " + customer.Salary);
            }

            // Sort() method should sort customers by salary
            listCutomers.Sort();

            Console.WriteLine("Customers after sorting");
            foreach (Customer78 customer in listCutomers)
            {
                Console.WriteLine(customer.Name + " - " + customer.Salary);
            }

            // To sort customers by name instead of salary
            SortByName sortByName = new SortByName();
            listCutomers.Sort(sortByName);

            Console.WriteLine("Customers after sorting by Name");
            foreach (Customer78 customer in listCutomers)
            {
                Console.WriteLine(customer.Name + " - " + customer.Salary);
            }
        }
        #endregion

        #region SeventyNine
        public void seventyNine()
        {
            Customer79 customer1 = new Customer79()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer79 customer2 = new Customer79()
            {
                ID = 103,
                Name = "John",
                Salary = 7000
            };

            Customer79 customer3 = new Customer79()
            {
                ID = 102,
                Name = "Ken",
                Salary = 5500
            };

            List<Customer79> listCutomers = new List<Customer79>();
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);

            Console.WriteLine("Customers before sorting");
            foreach (Customer79 customer in listCutomers)
            {
                Console.WriteLine(customer.ID);
            }

            // Approach 1
            // Step 2: Create an instance of Comparison delegate
            //Comparison<Customer79> customerComparer = 
            //    new Comparison<Customer79>(CompareCustomers);

            // Step 3: Pass the delegate instance to the Sort method
            //listCutomers.Sort(customerComparer);

            // Approach 2: Using delegate keyword
            //listCutomers.Sort(delegate(Customer79 c1, Customer79 c2)
            //{
            //    return (c1.ID.CompareTo(c2.ID));
            //});

            // Aaproach 3: Using lambda expression
            listCutomers.Sort((x, y) => x.ID.CompareTo(y.ID));

            Console.WriteLine("Customers after sorting by ID");
            foreach (Customer79 customer in listCutomers)
            {
                Console.WriteLine(customer.ID);
            }

            listCutomers.Reverse();
            Console.WriteLine("Customers in descending order of ID");
            foreach (Customer79 customer in listCutomers)
            {
                Console.WriteLine(customer.ID);
            }
        }

        // Approach 1 - Step 1
        // Method that contains the logic to compare customers
        private static int CompareCustomers(Customer79 c1, Customer79 c2)
        {
            return c1.ID.CompareTo(c2.ID);
        }
        #endregion

        #region Eighty
        public void eighty()
        {
            Customer80 customer1 = new Customer80()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5200
            };

            Customer80 customer2 = new Customer80()
            {
                ID = 103,
                Name = "John",
                Salary = 7000
            };

            Customer80 customer3 = new Customer80()
            {
                ID = 102,
                Name = "Ken",
                Salary = 5500
            };

            List<Customer80> listCutomers = new List<Customer80>(100);
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);

            Console.WriteLine("Are all salaries greater than 5000: "
                + listCutomers.TrueForAll(x => x.Salary > 5000));

            // ReadOnlyCollection will not have Add() or Remove() methods
            System.Collections.ObjectModel.ReadOnlyCollection<Customer80>
                readOnlyCustomers = listCutomers.AsReadOnly();

            Console.WriteLine("Total Items in ReadOnlyCollection = " +
                readOnlyCustomers.Count);

            // listCutomers list is created with an initial capacity of 100
            // but only 3 items are in the list. The filled percentage is 
            // less than 90 percent threshold.
            Console.WriteLine("List capacity before invoking TrimExcess = " +
                    listCutomers.Capacity);
            // Invoke TrimExcess() to set the capacity to the actual 
            // number of elements in the List
            listCutomers.TrimExcess();
            Console.WriteLine(listCutomers.Capacity);
        }
        #endregion

        #region EightyTwo
        public void eightyTwo()
        {
            Customer82 customer1 = new Customer82()
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };

            Customer82 customer2 = new Customer82()
            {
                ID = 102,
                Name = "Pam",
                Gender = "Female"
            };

            Customer82 customer3 = new Customer82()
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };

            Customer82 customer4 = new Customer82()
            {
                ID = 104,
                Name = "Ken",
                Gender = "Male"
            };

            Customer82 customer5 = new Customer82()
            {
                ID = 105,
                Name = "Valarie",
                Gender = "Female"
            };

            // Create a Queue
            Queue<Customer82> queueCustomers = new Queue<Customer82>();
            // To add an item to the queue, use Enqueue() method
            // customer1 is added first, so this customer, will be the first to get out of the queue
            queueCustomers.Enqueue(customer1);
            // customer2 will be queued up next, so customer2 will be second to get out of the queue
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            // To retrieve an item from the queue, use Dequeue() method. Notice that the 
            // items are dequeued in the same order in which they were enqueued.
            // Dequeue() method removes and returns the item at the beginning of the Queue.
            Customer82 c1 = queueCustomers.Dequeue();
            Console.WriteLine(c1.ID + " -  " + c1.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer82 c2 = queueCustomers.Dequeue();
            Console.WriteLine(c2.ID + " -  " + c2.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer82 c3 = queueCustomers.Dequeue();
            Console.WriteLine(c3.ID + " -  " + c3.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer82 c4 = queueCustomers.Dequeue();
            Console.WriteLine(c4.ID + " -  " + c4.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer82 c5 = queueCustomers.Dequeue();
            Console.WriteLine(c5.ID + " -  " + c5.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");

            // After customer5 is dequeued, there will be no items left in the 
            // queue. So, let's enqueue the five objects once again
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            // If you need to loop thru items in the queue, foreach loop can be used in the 
            // same way as we use it with other collection classes. The foreach loop will
            // only iterate thru items in the queue, but will not dequeue them.
            foreach (Customer82 customer in queueCustomers)
            {
                Console.WriteLine(customer.ID + " -  " + customer.Name);
                Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
            }
            Console.WriteLine("-----------------------------------------------------------");

            // To retrieve an item that is present at the beginning of the 
            // queue, without removing it use Peek() method.
            Customer82 c = queueCustomers.Peek();
            Console.WriteLine(c.ID + " -  " + c.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");

            // To check if an item, exists in the queue, use Contains() method.
            if (queueCustomers.Contains(customer1))
            {
                Console.WriteLine("customer1 is in Queue");
            }
            else
            {
                Console.WriteLine("customer1 is not in Queue");
            }
        }
        #endregion

        #region EightyThree
        public void eightyThree()
        {
            Customer83 customer1 = new Customer83()
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };

            Customer83 customer2 = new Customer83()
            {
                ID = 102,
                Name = "Pam",
                Gender = "Female"
            };

            Customer83 customer3 = new Customer83()
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };

            Customer83 customer4 = new Customer83()
            {
                ID = 104,
                Name = "Ken",
                Gender = "Male"
            };

            Customer83 customer5 = new Customer83()
            {
                ID = 105,
                Name = "Valarie",
                Gender = "Female"
            };

            // Create a Stack
            Stack<Customer83> stackCustomers = new Stack<Customer83>();
            // To add an item to the stack, use Push() method.
            // customer1 is inserted at the top of the stack
            stackCustomers.Push(customer1);
            // customer2 will be inserted on top of customer1 and now is on top of the stack
            stackCustomers.Push(customer2);
            // customer3 will be inserted on top of customer2 and now is on top of the stack
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            // To retrieve an item from the stack, use Pop() method. This method 
            // removes and returns an object at the top of the stack. Since customer5
            // object is the one that is pushed onto the stack last, this object will be
            // first to be removed and returned from the stack by the Pop() method
            Customer83 c1 = stackCustomers.Pop();
            Console.WriteLine(c1.ID + " -  " + c1.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer83 c2 = stackCustomers.Pop();
            Console.WriteLine(c2.ID + " -  " + c2.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer83 c3 = stackCustomers.Pop();
            Console.WriteLine(c3.ID + " -  " + c3.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer83 c4 = stackCustomers.Pop();
            Console.WriteLine(c4.ID + " -  " + c4.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer83 c5 = stackCustomers.Pop();
            Console.WriteLine(c5.ID + " -  " + c5.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");
            // After customer5 is removed, there will be no items left in the 
            // stack. So, let's push the five objects once again
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            // If you need to loop thru items in the stack, foreach loop can be used in the same 
            // way as we use it with other collection classes. The foreach loop will only iterate 
            // thru items in the stack, but will not remove them. Notice that the items from the 
            // stack are retrieved in LIFO (Last In First Out), order. The last element added to 
            // the Stack is the first one to be removed.
            foreach (Customer83 customer in stackCustomers)
            {
                Console.WriteLine(customer.ID + " -  " + customer.Name);
                Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);
            }
            Console.WriteLine("-----------------------------------------------------------");

            // To retrieve an item that is present at the top of the 
            // stack, without removing it use Peek() method.
            Customer83 c = stackCustomers.Peek();
            Console.WriteLine(c.ID + " -  " + c.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");

            Customer83 c99 = stackCustomers.Peek();
            Console.WriteLine(c99.ID + " -  " + c99.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");
            // To check if an item, exists in the stack, use Contains() method.
            if (stackCustomers.Contains(customer1))
            {
                Console.WriteLine("customer1 is in stack");
            }
            else
            {
                Console.WriteLine("customer1 is not in stack");
            }
        }
        #endregion

        #region NintyOne
        public void nintyOne()
        {
            Console.WriteLine("Please enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallback callback = new SumOfNumbersCallback(printSum);

            Number91 number91 = new Number91(target, callback);
            Thread T1 = new Thread(new ThreadStart(number91.PrintSumOfNumbers));
            T1.Start();
        }

        public static void printSum(int sum)
        {
            Console.WriteLine("Sum of Numbers = " + sum);
        }
        #endregion

        #region NintyEight
        /*
         * Anonymous Methods
         */
        public void nintyEight()
        {
            List<Employee98> lisEmployees = new List<Employee98>()
            { 
                new Employee98 {Id=101, Name="Mark"},
                new Employee98 {Id=102, Name="John"},
                new Employee98 {Id=103, Name="Mary"}
            };

            //step 2
            //Predicate<Employee98> employeePredicate = new Predicate<Employee98>(FindEmployee);

            //step 3
            //Employee98 employee98 = lisEmployees.Find(emp => FindEmployee(emp));
            Employee98 employee98 = lisEmployees.Find(delegate (Employee98 emp)
            {
                return emp.Id == 102;
            });
            Console.WriteLine("ID={0}, Name={1}", employee98.Id, employee98.Name);
        }

        //step 1
        //public static bool FindEmployee(Employee98 emp)
        //{
        //    return emp.Id==102;
        //}
        #endregion

        #region NintyNine
        /*
         * Lambda Expressions
         */
        public void nintyNine()
        {
            List<Employee98> lisEmployees99 = new List<Employee98>()
            {
                new Employee98 {Id=101, Name="Mark"},
                new Employee98 {Id=102, Name="John"},
                new Employee98 {Id=103, Name="Mary"}
            };

            Employee98 employee99 = lisEmployees99.Find(emp => emp.Id == 102);
            Console.WriteLine("ID={0}, Name={1}", employee99.Id, employee99.Name);

            int count = lisEmployees99.Count(x => x.Name.StartsWith("M"));
            Console.WriteLine("Count = {0}", count);
        }
        #endregion

        #region Hundered
        /*
         * Lambda Expressions
         */
        public void hundered()
        {
            List<Employee98> lisEmployees100 = new List<Employee98>()
            {
                new Employee98 {Id=101, Name="Mark"},
                new Employee98 {Id=102, Name="John"},
                new Employee98 {Id=103, Name="Mary"}
            };

            //Func<Employee98, string> selector = emp => "Name : " + emp.Name;
            IEnumerable<string> names = lisEmployees100.Select(emp => "Name : " + emp.Name);

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
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
            Console.WriteLine("Full Name is:" + this._firstName + ", " + this._LastName);
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

        public Circle(int Radius)
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

    #region TwentySix
    public class Student26
    {
        private int _id;
        private string _name;
        private int _passMark;

        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student id should be greater than zero");
            }
            this._id = id;
        }

        public int GetId()
        {
            return this._id;
        }

        public string getName()
        {
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        }
    }
    #endregion

    #region TwentySeven
    /*
     * Properties - getter and setter methods before properties
     */
    public class Student27
    {
        private int _id;
        private string _name;
        private int _passMark;

        public int id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student id cannot be negative");
                }
                this._id = value;
            }

            get
            {
                return this._id;
            }
        }

        //read-only property
        public int passMark
        {
            get
            {
                return this._passMark;
            }
        }

        //Auto Implemented properties
        //This is no where related to _name field, because C# automatically creates a new private field "name"
        public string name
        {
            set;
            get;
        }

        //Auto implemented properties creates a new private field.
        public string emailId
        {
            set;
            get;
        }

        public string city { get; set; }
    }
    #endregion

    #region TwentyEight
    public struct Customer28
    {
        private int _id;
        private string _name;

        public int id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        //Created using refactoring by right clicking
        public string name { get => _name; set => _name = value; }

        //Struct Constructor
        public Customer28(int Id, String Name)
        {
            this._id = Id;
            this._name = Name;
        }

        //Struct Method
        public void printDetails()
        {
            Console.WriteLine("Id={0} && Name={1}", this._id, this._name);
        }
    }
    #endregion

    #region Thirty
    interface ICustomer30
    {
        void print1();
    }

    interface ICustomer30_2 : ICustomer30
    {
        void print2();
    }

    public class Customer_30 : ICustomer30_2
    {
        public void print1()
        {
            Console.WriteLine("Interface1 method implemented");
        }

        public void print2()
        {
            Console.WriteLine("Interface2 method implemented");
        }
    }
    #endregion

    #region ThirtyOne
    /*
     *Explicit Interface Implementation 
     */
    interface I31_1
    {
        void interfaceMethod31();
    }

    interface I31_2
    {
        void interfaceMethod31();
    }

    public class Program_31 : I31_1, I31_2
    {
        //In this implementation, we are not sure which interface this method belongs to
        //compiler thinks that we implemented for both the interfaces, to implement for both interfaces
        //We need to do 2 changes 1. remove access mosifier and use dot notation to specify the interface
        //This method below is going to be the default method
        public void interfaceMethod31()
        {
            Console.WriteLine("interfaceMethod31 implemented in program_31 class - Default Implementation");
        }


        void I31_1.interfaceMethod31()
        {
            Console.WriteLine("interfaceMethod31_1 implemented in program_31 class");
        }

        void I31_2.interfaceMethod31()
        {
            Console.WriteLine("interfaceMethod31_2 implemented in program_31 class");
        }
    }
    #endregion

    #region ThirtyTwo
    //Abstract Classes
    public abstract class Customer_32
    {
        public abstract void print();
    }

    public class Program_32 : Customer_32
    {
        public override void print()
        {
            Console.WriteLine("Print Method");
        }
    }
    #endregion

    #region ThirtyFive
    //Multiple class inheritance using interfaces
    interface I35_a
    {
        void aMethod();
    }
    class A_35 : I35_a
    {
        public void aMethod()
        {
            Console.WriteLine("class A_35 aMethod inherited from I35_a");
        }
    }

    interface I35_b
    {
        void bMethod();
    }
    class B_35 : I35_b
    {
        public void bMethod()
        {
            Console.WriteLine("class B_35 bMethod inherited from I35_b");
        }
    }

    class AB_35 : I35_a, I35_b
    {
        A_35 a_35 = new A_35();
        B_35 b_35 = new B_35();

        public void aMethod()
        {
            a_35.aMethod();
        }

        public void bMethod()
        {
            b_35.bMethod();
        }
    }
    #endregion

    #region ThirtySix
    //Delegates
    public delegate void HelloFuncDelegate36(string message);
    #endregion

    #region ThirtySeven
    class Employee37
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void promoteEmployee(List<Employee37> empList)
        {
            foreach (Employee37 e in empList)
            {
                if (e.Experience >= 5)
                {
                    Console.WriteLine(e.Name + " Promoted");
                }
            }
        }
    }
    #endregion

    #region ThirtyEight
    delegate bool IsPromotable38(Employee38 emp);

    class Employee38
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void promoteEmployee(List<Employee38> empList, IsPromotable38 isPromotable38)
        {
            foreach (Employee38 e in empList)
            {
                if (isPromotable38(e))
                {
                    Console.WriteLine(e.Name + " Promoted");
                }
            }
        }
    }
    #endregion

    #region ThirtyNine
    public delegate void SampleDelegate39();
    #endregion

    #region FourtyTwo
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException()
            : base()
        {
        }

        public UserAlreadyLoggedInException(string message)
            : base(message)
        {
        }

        public UserAlreadyLoggedInException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
    #endregion

    #region FourtyFive
    //0-Male
    //1-Female
    //2-Unknown
    class Customer45
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
    #endregion

    #region FourtySix
    public enum Gender46
    {
        Male,
        Female,
        Unknown
    }

    class Customer46
    {
        public string Name { get; set; }
        public Gender46 Gender { get; set; }
    }
    #endregion

    #region FourtySeven
    public enum Gender47 : short
    {
        Male = 1,
        Female = 5,
        Unknown = 7
    }
    #endregion

    #region FiftyTwo
    public class Calculator52
    {
        [Obsolete("Use Addm method instead of Add")]
        public int Add(int fn, int sn)
        {
            return fn + sn;
        }

        //You can't use this method as we set error to true which means to throw error
        [Obsolete("Don't use this method", true)]
        public int Add_dont_use(int fn, int sn)
        {
            return fn + sn;
        }

        public int Addm(params int[] fn)
        {
            int sum = 0;
            foreach (int i in fn)
            {
                sum += i;
            }
            return sum;
        }
    }
    #endregion

    #region FiftyThree
    public class Customer53
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer53(int Id, String Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public Customer53()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void printId()
        {
            Console.WriteLine("ID is :{0}", this.Id);
        }

        public void printName()
        {
            Console.WriteLine("Name is :{0}", this.Name);
        }
    }
    #endregion

    #region FiftyFive
    // Late Binding using Reflection
    public class Customer55
    {
        public string getFullName(string fn, string ln)
        {
            return fn + " " + ln;
        }
    }
    #endregion

    #region FiftySix
    public class Calculator56
    {
        public bool AreEqual(object o1, object o2)
        {
            return o1 == o2;
        }

        //In this case we made the method generic, Instead we can also make the class generic
        public bool AreEqualUsingGenerics<T>(T o1, T o2)
        {
            return o1.Equals(o2);
        }
    }

    public class Calculator56_1<T>
    {
        public bool AreEqual(object o1, object o2)
        {
            return o1 == o2;
        }

        //In this case we made the method generic, Instead we can also make the class generic
        public bool AreEqualUsingGenerics(T o1, T o2)
        {
            return o1.Equals(o2);
        }
    }
    #endregion

    #region FiftySeven
    public class Customer57
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override string ToString()
        {
            return firstName + ", " + lastName;
        }
    }
    #endregion

    #region FiftyEight
    public enum Directions58
    {
        East,
        West,
        North,
        South
    }

    public class Customer58
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Customer58))
            {
                return false;
            }

            return this.firstName == ((Customer58)obj).firstName && this.lastName == ((Customer58)obj).lastName;
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }
    }
    #endregion

    #region FiftyNine
    public class Customer59
    {
        public string Name { get; set; }
    }
    #endregion

    #region sixtyOne
    //We can also place this 2 blocks of code in 2 different files
    public partial class Customer61
    {
        public string _firstName;
        public string _lastName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }

    public partial class Customer61
    {
        public string getFullName()
        {
            return _firstName + ", " + _lastName;
        }
    }
    #endregion

    #region SixtyThree
    public partial class SamplePartialClass63
    {
        partial void SamplePartialMethod63();

        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod Invoked");
            SamplePartialMethod63();
        }
    }

    public partial class SamplePartialClass63
    {
        partial void SamplePartialMethod63()
        {
            Console.WriteLine("Partialmethod invoked");
        }
    }
    #endregion

    #region SeventyTwo
    /*
     * Dictionary
     */
    public class Customer72
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    #endregion

    #region SeventyFour
    public class Customer74
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    #endregion

    #region SeventySix
    public class Customer76
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
    #endregion

    #region SeventySeven
    public class Customer77
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
    #endregion

    #region SeventyEight
    public class Customer78 : IComparable<Customer78>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        //public int CompareTo(Customer78 other)
        //{
        //    if (this.Salary > other.Salary)
        //        return 1;
        //    else if (this.Salary < other.Salary)
        //        return -1;
        //    else
        //        return 0;
        //}

        public int CompareTo(Customer78 other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }

    public class SortByName : IComparer<Customer78>
    {
        public int Compare(Customer78 X, Customer78 Y)
        {
            return X.Name.CompareTo(Y.Name);
        }
    }
    #endregion

    #region SeventyNine
    public class Customer79
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    #endregion

    #region Eighty
    public class Customer80
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    #endregion

    #region EightyTwo
    public class Customer82
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    #endregion

    #region EightyThree
    public class Customer83
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    #endregion

    #region NintyOne
    public delegate void SumOfNumbersCallback(int SumOfNumbers);

    public class Number91
    {
        int _target;
        SumOfNumbersCallback _callBackMethod;

        public Number91(int target, SumOfNumbersCallback callBackMethod)
        {
            this._target = target;
            this._callBackMethod = callBackMethod;
        }

        public void PrintSumOfNumbers()
        {
            int sum = 0;
            for(int i=0; i<=_target; i++)
            {
                sum += i;
            }

            if(_callBackMethod != null)
            {
                _callBackMethod(sum);
            }
        }
    }
    #endregion

    #region NintyEight
    public class Employee98
    {
        public int Id { get; set; }
        public String Name { get; set; }
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