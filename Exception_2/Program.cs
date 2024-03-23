using System;
using System.Collections.Generic;

namespace Exception_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> args1 = new List<int>();

            while (args1.Count < 10)
            {
                string input = Console.ReadLine();
                int j = 1;
                try
                {

                    int n = int.Parse(input);
                    if (args1.Count != 0)
                    {
                        j = args1[0];
                    }
                    
                    int number = ReadNumbers(n,j);
                    int currIndex = args1.Count;
                    if (currIndex > 0)
                    {
                        if (number > args1[currIndex-1])
                        {
                            args1.Add(number);
                        }
                    }
                    else
                    {
                        args1.Add(number);
                    }
                    if (args1.Count == 10) 
                    {
                        break;
                    }
                    

                }


                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                    
                }
                catch (Exception)
                {
                    Console.WriteLine($"Your number is not in range {j} - 100!");
                }

            }
            Console.WriteLine(String.Join(", ", args1));
        }

        public static int ReadNumbers(int n,int j) 
        {
            if (n <= j || n >= 100)
            {
                throw new ArgumentException();
            }
            else 
            {
                return n;
            }
            

        }
    }
}
