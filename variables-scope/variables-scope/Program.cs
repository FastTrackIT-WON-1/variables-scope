using System;

namespace variables_scope
{
    class Program
    {
        /* Class scope */
        private static int i = 0;

        static void PrintMember()
        {
            /* Accessing a class member */
            Console.WriteLine($"i={i}");
        }

        static void PrintNumber(int i)
        {
            /* A parameter has function scope */
            Console.WriteLine($"i={i}");
        }

        static void Sum(int a, int b)
        {
            /* variable shaddowing */
            int i = a + b;
            PrintNumber(i);
        }

        static void Main(string[] args)
        {
            PrintMember();

            Console.Write("Enter block scope (Y/N)? ");
            string reply = Console.ReadLine();

            if (string.Equals(reply, "Y", StringComparison.OrdinalIgnoreCase))
            {
                /* block scope, again variable shaddowing */
                Console.WriteLine("***** Start block scope *****");
                int i = 20;
                PrintNumber(i);
                Console.WriteLine("***** Stop block scope *****");
            }

            Sum(10, 20);
        }
    }
}
