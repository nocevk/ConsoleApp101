using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Task 1: ");

            string name = "Kirilo";
            int age = 17;
            Console.WriteLine("Hello, {0}, I'm {1} years old", name, age);
            //Console.WriteLine($Hello, my name is {name} {surname}, I'm {age} years old");
            Console.WriteLine("-------------------");

            //Task 2
            int a = 3;
            int b = 7;
            double result;

            result = (Math.Pow((a - b), 3) - Math.Pow(a, 3)) / (Math.Pow(b, 3) - 3 * a * Math.Pow(b, 2) - 3 * Math.Pow(a, 2) * b);
            Console.Write("_");
            Console.WriteLine("-------------------");
            Console.WriteLine("task 2:");
            Console.WriteLine($"result = {result}");



            //Task3        
            Console.Write("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());

            double first = number % 10;
            double second = (number % 100 - first) / 10;
            double third = number - second * 10 - first) / 100;

            string reversed = first.ToString() + second.ToString() + third.ToString();
            Console.WriteLine(reversed);
            Console.Read();

            Console.Write("-------------------");


        }
    }
}







           