namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exercises = new Exercices();

            var result = exercises.Factorial(6);
            result = exercises.Fibonacci(10);

            
            var reversedString = exercises.Reverse("marcus");
        }
    }
}
