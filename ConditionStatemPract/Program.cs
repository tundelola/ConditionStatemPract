using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionStatemPract
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a C# Sharp program to accept two integers and check whether they are equal or not.
            //get input
            //  Console.WriteLine("Enter the first number");
            //  int num1 = Convert.ToInt32(Console.ReadLine());

            //int int1 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Enter the second number");
            // int num2 = Convert.ToInt32(Console.ReadLine());

            //  int int2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 == num2)
            //{
            //    Console.WriteLine("num1 and num2 are equal");
            //}
            //else
            //{
            //    Console.WriteLine("num1 and num2 are NOT equal");
            //}

            //if (int1 == int2)
            //    Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
            //else
            //    Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);

            //Write a C# Sharp program to check whether a given number is even or odd
            //Console.WriteLine("Enter a number");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //if (num1 % 2 == 0)
            //{

            //    Console.WriteLine("It is an even number {0}", num1);
            //}
            //else

            //    Console.WriteLine("It is an odd number {0}", num1);

            //Write a C# Sharp program to check whether a given number is positive or negative


            //Console.WriteLine("Enter a number");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //if (num1>= 0)
            //{

            //    Console.WriteLine("It is a positive number {0}", num1);
            //}
            //else

            //    Console.WriteLine("It is a negative number {0}", num1);

            //Write a C# Sharp program to find the largest of three numbers

            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                if (num1 > num3)
                {

                    Console.WriteLine("The first number is the greatest");

                }
                else
                {
                    Console.WriteLine("The third number is the greatest");
                }

           else if (num2 > num3)

            {
                Console.WriteLine("The second number is the greatest");

            }
            else
            {
                Console.WriteLine("The third number is the greatest");
            }

        }
    }
}
