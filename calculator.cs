using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int V1;
            int V2;
            while (true)
            {

                try
                {

                    
                Console.Write("Enter value 1:");
                var value1 = Console.ReadLine();
                   
                    if (Int32.TryParse(value1, out V1))
                        Console.WriteLine(V1);
                    else
                    {
                         
                        Console.WriteLine("String could not be parsed.");
                        continue;
                    }                   

                    Console.Write("Enter value 2:");
                    var value2 = Console.ReadLine();

                    if (Int32.TryParse(value2, out V2))
                        Console.WriteLine(V2);
                    else
                    {

                        Console.WriteLine("String could not be parsed.");
                        continue;
                    }

                    Console.Write("(A)dd, (S)ubtract, (M)ultiple, (D)ivide:");
                var letter = Console.ReadLine();
                    string action = letter.ToUpper();

                if (action == "A")
                {
                    var addition = double.Parse(value1) + double.Parse(value2);
                    Console.WriteLine("Result is " + addition);
                }

                else if (action == "S")
                {
                    var subtraction = double.Parse(value1) - double.Parse(value2);
                    Console.WriteLine("Result is " + subtraction);
                }


                else if (action == "M")
                {
                    var Multuplication = double.Parse(value1) * double.Parse(value2);
                    Console.WriteLine("Result is " + Multuplication);
                }


                else if (action == "D")
                {
                    var Division = double.Parse(value1) / double.Parse(value2);
                    Console.WriteLine("Result is " + Division);

                }
                    else
                    {
                        Console.WriteLine("That is not a valid entry. Try again");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid imput");
                    continue;

                }
            }




















        }

        private static string GetAddition(string addition)
        {
            return addition;
        }
    }
}
