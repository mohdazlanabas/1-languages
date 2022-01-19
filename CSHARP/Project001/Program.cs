using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Project001
{
    class MainClass
    {
        static void Main(string[] args)
        {
            /* IF STATEMENT- BASIC CALCULATOR APP
            Console.Write("Enter a First number: ");
            double numA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a Second number: ");
            double numB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an Operator (+ - / *) : ");
            string op = Console.ReadLine();
            if (op == "+") { 
            Console.WriteLine("The answer is: " + (numA + numB));
            } else if (op == "-") {
            Console.WriteLine("The answer is: " + (numA - numB));
            } else if (op == "/") {
            Console.WriteLine("The answer is: " + (numA / numB));
            } else if (op == "*") { 
            Console.WriteLine("The answer is: " + (numA * numB));
            } else { Console.WriteLine("Invalid Operator"); }*/

            //IF STATEMENT- GET MAX and Exponential using METHODS
            Console.WriteLine(GetMax(20, 10, 40));
            Console.WriteLine(GetPow(3, 2));

            // 2D Array
            int[,] numberGrid =
            {
                {1,2 },{3,4},{5,6}
            };
            int[,] myArray = new int[2, 3];
            Console.WriteLine(numberGrid[0, 0]);

            // EXCEPTIONS
            try
            {
                Console.WriteLine("Enter a number: ");
                int num4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int num5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num4 / num5);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        } static int GetMax(int num1, int num2, int num3)
            {
                int result;
                if (num1 >= num2 && num1 >= num3)
                { result = num1; }
                else if (num2 >= num1 && num2 >= num3)
                { result = num2; }
                else { result = num3; }
                return result;

        } static int GetPow(int baseNum, int powNum)
            {
                int result2 = 1;
                for (int i = 0; i < powNum; i++)
                { result2 = result2 * baseNum; }
                return result2;


        }
    }
}
