using System;

namespace Exerceise1
    {
    class Program
        {
        static void Main(string[] args)
            {
            //Part 1

            string name;
            string text;
            int age;
            int years;
            Console.Write("Input your name: ");
            name = Console.ReadLine();
            Console.Write("Input age: ");
            text = Console.ReadLine();
            age = int.Parse(text);
            Console.Write("How many years have passed: ");
            text = Console.ReadLine();
            years = int.Parse(text);
            Console.WriteLine($"Your name is {name}. You will be {age + years} years old in {years} years");
            Console.WriteLine();
            Console.WriteLine();

            //Part2

            int length;
            int width;
            Console.Write("Input room Length: ");
            text = Console.ReadLine();
            length = int.Parse(text);
            Console.Write("Input room Width: ");
            text = Console.ReadLine();
            width = int.Parse(text);
            Console.WriteLine($"The area of the room is {length * width}");
            }
        }
    }
