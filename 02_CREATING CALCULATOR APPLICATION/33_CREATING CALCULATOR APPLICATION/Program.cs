using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _33_CREATING_CALCULATOR_APPLICATION
{
    class Program
    {
        public static void addation(int num1 , int  num2)
        {
            int resutl = num1 + num2;
            Console.WriteLine("addation result is : {0}", resutl);
        }
        public static void subtraction(int num1, int num2)
        {
            int resutl = num1 - num2;
            Console.WriteLine("subtraction result is : {0}", resutl);
        }
        public static void multplication(int num1, int num2)
        {
            int resutl = num1 * num2;
            Console.WriteLine("multiplaction result is : {0}" ,resutl);
        }
        public static void divison(int num1, int num2)
        {
            int resutl = num1 / num2;
            Console.WriteLine("division result is : {0}" ,resutl);
        }

        static void Main(string[] args)
        {
            // how to creat a calculator

            Console.WriteLine("Enter a first number :");
            int userFristInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number :");
            int userSecondInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Operator : ( +, -, *, /) ");
            string opt = Console.ReadLine();

            if (opt == "+")
            {
                Program.addation(userFristInput , userSecondInput);
            }
            else if (opt == "-")
            {
                Program.subtraction(userFristInput , userSecondInput);
            }
            else if (opt == "*")
            {
                Program.multplication(userFristInput, userSecondInput);
            }
            else if (opt == "/")
            {
                Program.divison(userFristInput, userSecondInput);
            }

            Console.ReadLine();
        }
    }
}
