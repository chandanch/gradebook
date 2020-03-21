using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 23.12, 34.13, 90.12 };

            var result = 0.0;
            foreach (double number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }

        }
    }
}
