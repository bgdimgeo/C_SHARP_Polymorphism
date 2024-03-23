using System;

namespace Exceptions_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                int n = int.Parse(input);
                if (n <= 0) 
                {
                    throw new ArithmeticException();
                }
                double k = Math.Sqrt(n);
                Console.WriteLine(k);

            }
            catch (ArithmeticException) 
            {
                Console.WriteLine("Invalid number");
            }           
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
