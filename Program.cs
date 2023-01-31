using System;

namespace Deliverable3_IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1 and 100: ");
            int input = int.Parse(Console.ReadLine());

            Console.Write("Specify if series type is even or odd:");
            string series = Console.ReadLine();

            try
            {
                if (series == "odd")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                    for (int i = 1; i < input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (series == "even")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                    for (int i = 0; i < input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            catch
            {
                Console.WriteLine("Enter a numeric value.");
            }
            
        }
    }
}
