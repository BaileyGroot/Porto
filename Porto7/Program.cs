using System;

namespace Porto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave Porto

            Console.WriteLine("Welcome to Port2Port!");
            Console.WriteLine("Choose package");
            Console.WriteLine("50g - 100g - 250g - 500g");

            string package = Console.ReadLine();

            Console.WriteLine("Choose Country");
            Console.WriteLine("USA - DK");

            string country = Console.ReadLine();

            // Kode
            // USA Package Port

            if (package == "50g" && country == "USA")
            {
                Console.WriteLine("Pris: 33 - USA - 50g");
                return;
            }
            else if (package == "100g" && country == "USA")
            {
                Console.WriteLine("Pris: 33 - USA - 100g");
                return;
            }
            else if (package == "250g" && country == "USA")
            {
                Console.WriteLine("Pris: 66 - USA - 250g");
                return;
            }
            else if (package == "500g" && country == "USA")
            {
                Console.WriteLine("Pris: 99 - USA - 500g");
                return;
            }
            else
            {
                Console.WriteLine("\n");
            }


            // DK Package Port

            if (package == "50g" && country == "DK")
            {
                Console.WriteLine("Pris: 11 - DK - 50g");
                return;
            }
            else if (package == "100g" && country == "DK")
            {
                Console.WriteLine("Pris: 22 - DK - 100g");
                return;
            }
            else if (package == "250g" && country == "DK")
            {
                Console.WriteLine("Pris: 44 - DK - 250g");
                return;
            }
            else if (package == "500g" && country == "DK")
            {
                Console.WriteLine("Pris: 66 - DK - 500g");
                return;
            }
            else
            {
                Console.WriteLine("Fejl: Vær sikker på du skriver det præcis.");
            }

            // Preventing the program from shutting down.
            Console.ReadKey();
        }
    }
}
