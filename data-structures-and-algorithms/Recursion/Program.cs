namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exercises = new Exercices();

            var result = exercises.Fibonacci(6);
            Console.WriteLine();
            result = exercises.FibonacciDynamic(10);
            result = exercises.FibonacciDynamic(11);
            Console.WriteLine();

            
        }
    }
}
