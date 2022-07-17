using System;

namespace MethodsExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            
            Console.WriteLine($"My name is {name}, my favorite animal is a {color} {animal} and the best band ever is {band}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Give me a second number to add");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("Give me a number to multiply");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Give me a second number to multiply");
            num2 = int.Parse(Console.ReadLine());

            int solution = Multiply(num1, num2);
            Console.WriteLine($"The solution is {solution}");




        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}

