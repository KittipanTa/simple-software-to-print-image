using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_software_to_print_image
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                try 
                {
                    Console.WriteLine("Enter a number: ");
                    string input = Console.ReadLine();
                    int number;
                    if (int.TryParse(input, out number)&& number > 2)
                    {
                        Triangle triangle = new Triangle(number);
                        triangle.GenerateTriangle();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a integer number.and more two ");
                    }
                    Console.WriteLine("Again y/n");
                    string ck = Console.ReadLine().ToString();
                    if (ck == "n") {
                        break;
                    }
                    Console.Clear();
                }
                catch (FormatException ex) {
                    Console.WriteLine("Invalid format: {0}", ex);
                }
            }
            
        }
    }
    class Triangle
    {
        private int size;

        public Triangle(int size)
        {
            this.size = size;
        }

        public void GenerateTriangle()
        {
            for (int i = 1; i < size; i++)
            {
                for (int j = size - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i * 2 - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (int x = 1;x <= 2; x++ ) {
                for (int y = size - x; y > 0; y--)
                {
                    Console.Write(" ");
                }

                for (int z = 1; z <= x * 2 - 1; z++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
    }
}
