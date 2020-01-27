using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquation2ndVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type linear equations in augmented matrix notation: a1 a2... aN d, " +
                "where a1..N are coefficients and d is contant");
            Console.WriteLine("Type END to finish entering equations");

            int index = 1;

            Matrix matrix = new Matrix();
            try
            {
                while (true)
                {
                    Console.Write($"Eq #{index++}: ");

                    String input = Console.ReadLine();

                    if (input.Trim() == "END")
                        break;


                    matrix.addEquation(new Equation(input));

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: " + e.Message);
            }

            Console.WriteLine("You have entered following equations:");

            for (int i = 0; i < matrix.Length; i++)
                Console.Write($"Eq #{i}: {matrix.getEquation(i)}\n");

            Console.WriteLine("Result is:");
            matrix.printResults();
        }
    }
}

