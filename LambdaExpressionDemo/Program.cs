
// Amir Moeini Rad
// May 3, 2025

// Main Concept: Demonstrating the use of lambda expressions in C#

namespace LambdaExpressionDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Working with Lambda Expressions in C#.NET...");
            Console.WriteLine("--------------------------------------------\n");

            // Lambda expression to add two numbers
            // 'add' is a delegate that takes two integers and returns their sum.
            // Therefore, in practice, we are defining an anonymous method.
            // 'Func<>' is a built-in delegate type in C# that represents a method that returns a value.
            // Lambda expressions are usually used to create delegates or expression tree types.
            Func<int, int, int> add = (a, b) => a + b;


            Console.WriteLine($"Sum: {add(5, 3)}");


            Console.WriteLine("\nDone.");
        }
    }
}