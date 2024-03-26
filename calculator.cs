using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class calculator
    {
        static void Main()
        {
            Console.WriteLine("For Add, Sub, Product, Divide press 1 :");
            Console.WriteLine("For other operation press 2 :");
            int n = Convert.ToInt32(Console.ReadLine());

            // Switch case statements does not use braces for each case.
            // You need to remove the braces and terminate each case with a colon (:).
            switch (n)
            {
                case 2:
                    {
                        Console.WriteLine("Enter value to convert:");
                        double a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the operation (pow, sqrt, abs, ceil, floor):");
                        string oper = Console.ReadLine();

                        double result = 0;

                        // Need to use the variable 'a' instead of 'n' in the following calculation
                        switch (oper)
                        {
                            case "pow":
                                result = Math.Pow(a, a);
                                break;
                            case "sqrt":
                                result = Math.Sqrt(a);
                                break;
                            case "abs":
                                result = Math.Abs(a);
                                break;
                            case "ceil":
                                result = Math.Ceiling(a);
                                break;
                            case "floor":
                                result = Math.Floor(a);
                                break;
                 
                            default:
                                Console.WriteLine("Error: Invalid operation.");
                                return;
                        }
                        Console.WriteLine("Result: " + result);
                    }
                    break;

                case 1:
                    {
                        Console.WriteLine("Enter 1st value:");
                        double n1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter 2nd value:");
                        double n2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the operation (+, -, *, /, max, min ):");
                        string oper = Console.ReadLine();

                        double result = 0;

                        switch (oper)
                        {
                            case "+":
                                result = n1 + n2;
                                break;
                            case "-":
                                result = n1 - n2;
                                break;
                            case "*":
                                result = n1 * n2;
                                break;
                            case "max":
                                result = Math.Max(n1,n2);
                                break;
                            case "min":
                                result = Math.Min(n1, n2);
                                break;
                            case "/":
                                if (n2 == 0)
                                {
                                    Console.WriteLine("Error: Division by zero is not allowed.");
                                    return;
                                }
                                result = n1 / n2;
                                break;
                            default:
                                Console.WriteLine("Error: Invalid operation.");
                                return;
                        }
                        Console.WriteLine("Result: " + result);
                    }
                    break;
            }
        }
    }
}
