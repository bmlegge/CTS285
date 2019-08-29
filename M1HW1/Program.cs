using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Bradley Legge
* CTS 285 0001
* 8/27/2019
* This is a general calculator program.  It asks the user if they wish to add, subtract, divide or multiply
* two numbers.  It then asks them to enter two numbers and displays the calculation to them.
*/

namespace M1HW1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize bool value
            bool exit = false;

            //do while loop to display menu until user exits.
            do
            {
                //calls the menu method and stores the return value to input.
                string input = menu();

                //switch statement based on user input.
                switch (input)
                {
                    case "1":
                        sum();  //calls the sum method.
                        break;
                    case "2":
                        subtract();     //calls the subtract method.
                        break;
                    case "3":
                        divide();   //calls the divide method.
                        break;
                    case "4":
                        multiply();     //calls the mulitply method.
                        break;
                    case "5":
                        exit = true;    //exits the loop and terminates the program.
                        break;
                    default:
                        Console.WriteLine("Error! Invalid Choice!");    //user enters anything other than 1-5.
                        break;
                }
            } while (exit == false);    //exits the loop.
        }

        static string menu()
        {
            string userInput;

            //menu for uesr to choose from.
            Console.WriteLine("Welcome to the calculator program.");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Divide");
            Console.WriteLine("4. Multiply");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            userInput = Console.ReadLine();

            //returns the user input to main method.
            return userInput;
        }

        static void sum()
        {
            string userInput;   //user input
            int num1;       //first number entered.
            int num2;       //second number entered.
            int sum;        //hold calculation.
            string input = "1";     //initializes input variable so loop runs at least once.

            //while loop to run as long as user wants to user this option.
            while (input == "1")
            {
                //asks user for first number.
                Console.WriteLine("");
                Console.WriteLine("Addition");
                Console.Write("Enter the first number: ");
                userInput = Console.ReadLine();

                //parses user input into integer.
                if (int.TryParse(userInput, out num1))
                {
                    //asks user for second number.
                    Console.Write("Enter the second number: ");
                    userInput = Console.ReadLine();

                    //parses user input into integer.
                    if (int.TryParse(userInput, out num2))
                    {
                        //calculation.
                        sum = num1 + num2;

                        //displays output and asks user to repeat or main menu.
                        Console.WriteLine($"{num1} + {num2} = {sum}.");
                        Console.WriteLine("");
                        Console.WriteLine("1. Repeat");
                        Console.WriteLine("2. Main Menu");
                        Console.Write("Choose an option: ");
                        input = Console.ReadLine();
                        Console.WriteLine("");
                    }
                    //displays if user doesn't enter number.
                    else
                    {
                        Console.WriteLine("Error! Invalid number!");
                    }
                }
                //displays if user doesn't enter number.
                else
                {
                    Console.WriteLine("Error! Invalid number!");
                }
            }
        }

        static void subtract()
        {
            string userInput;   //user input
            int num1;       //first number entered.
            int num2;       //second number entered.
            int subtract;        //hold calculation.
            string input = "1";     //initializes input variable so loop runs at least once.

            //while loop to run as long as user wants to user this option.
            while (input == "1")
            {
                //asks user for first number.
                Console.WriteLine("");
                Console.WriteLine("Subtraction");
                Console.Write("Enter the first number: ");
                userInput = Console.ReadLine();

                //parses user input into integer.
                if (int.TryParse(userInput, out num1))
                {
                    //asks user for second number.
                    Console.Write("Enter the second number: ");
                    userInput = Console.ReadLine();

                    //parses user input into integer.
                    if (int.TryParse(userInput, out num2))
                    {
                        //calculation.
                        subtract = num1 - num2;

                        //displays output and asks user to repeat or main menu.
                        Console.WriteLine($"{num1} - {num2} = {subtract}.");
                        Console.WriteLine("");
                        Console.WriteLine("1. Repeat");
                        Console.WriteLine("2. Main Menu");
                        Console.Write("Choose an option: ");
                        input = Console.ReadLine();
                    }
                    //displays if user doesn't enter number.
                    else
                    {
                        Console.WriteLine("Error! Invalid number!");
                    }
                }
                //displays if user doesn't enter number.
                else
                {
                    Console.WriteLine("Error! Invalid number!");
                }
            }
        }

        static void divide()
        {
            string userInput;   //user input
            int num1;       //first number entered.
            int num2;       //second number entered.
            int divide;        //hold calculation.
            string input = "1";     //initializes input variable so loop runs at least once.

            //while loop to run as long as user wants to user this option.
            while (input == "1")
            {
                //asks user for first number.
                Console.WriteLine("");
                Console.WriteLine("Division");
                Console.Write("Enter the first number: ");
                userInput = Console.ReadLine();

                //parses user input into integer.
                if (int.TryParse(userInput, out num1))
                {
                    //asks user for second number.
                    Console.Write("Enter the second number: ");
                    userInput = Console.ReadLine();

                    //while loop if user enters 0 and asks to enter a number other than 0.
                    while (userInput == "0")
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        Console.Write("Enter another number: ");
                        userInput = Console.ReadLine();
                    }

                    //parses user input into integer.
                    if (int.TryParse(userInput, out num2))
                    {
                        //calculation.
                        divide = num1 / num2;

                        //displays output and asks user to repeat or main menu.
                        Console.WriteLine($"{num1} / {num2} = {divide}.");
                        Console.WriteLine("");
                        Console.WriteLine("1. Repeat");
                        Console.WriteLine("2. Main Menu");
                        Console.Write("Choose an option: ");
                        input = Console.ReadLine();
                    }
                    else
                    //displays if user doesn't enter number.
                    {
                        Console.WriteLine("Error! Invalid number!");
                    }
                }
                //displays if user doesn't enter number.
                else
                {
                    Console.WriteLine("Error! Invalid number!");
                }
            }
        }

        static void multiply()
        {
            string userInput;   //user input
            int num1;       //first number entered.
            int num2;       //second number entered.
            int multiply;        //hold calculation.
            string input = "1";     //initializes input variable so loop runs at least once.

            //while loop to run as long as user wants to user this option.
            while (input == "1")
            {
                //asks user for first number.
                Console.WriteLine("");
                Console.WriteLine("Multiplication");
                Console.Write("Enter the first number: ");
                userInput = Console.ReadLine();

                //parses user input into integer.
                if (int.TryParse(userInput, out num1))
                {
                    //asks user for second number.
                    Console.Write("Enter the second number: ");
                    userInput = Console.ReadLine();

                    //parses user input into integer.
                    if (int.TryParse(userInput, out num2))
                    {
                        //calculation.
                        multiply = num1 * num2;

                        //displays output and asks user to repeat or main menu.
                        Console.WriteLine($"{num1} * {num2} = {multiply}.");
                        Console.WriteLine("");
                        Console.WriteLine("1. Repeat");
                        Console.WriteLine("2. Main Menu");
                        Console.Write("Choose an option: ");
                        input = Console.ReadLine();
                    }
                    //displays if user doesn't enter number.
                    else
                    {
                        Console.WriteLine("Error! Invalid number!");
                    }
                }
                //displays if user doesn't enter number.
                else
                {
                    Console.WriteLine("Error! Invalid number!");
                }
            }
        }
    }
}
