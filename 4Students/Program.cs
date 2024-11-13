using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void SimpleCalculator()
        {
            Console.Write("Gebe die erste Zahl ein: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gebe die zweite Zahl ein: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gebe den Operator ein:");
            var _operator = Console.ReadLine();
        }

        static void SimpleCalculatorAlt()
        {
            Console.Clear();

            Console.Write("Gebe die erste Zahl ein: ");
            int.TryParse(Console.ReadLine(), out var numberOne);

            Console.Write("Gebe die zweite Zahl ein: ");
            int.TryParse(Console.ReadLine(), out var numberTwo);

            Console.Write("Gebe den Operator ein: ");
            char.TryParse(Console.ReadLine(), out var _operator);

            switch(_operator)
            {
                case '+':
                    var resultAdd = numberOne + numberTwo; 
                    Console.WriteLine(resultAdd);
                    break;

                case '-':
                    var resultSub = numberOne - numberTwo;
                    Console.WriteLine(resultSub); 
                    break;
                case '*':
                    var resultMult = numberOne * numberTwo;
                    Console.WriteLine(resultMult); 
                    break;                
                case '/':
                    var resultDiv = numberOne / numberTwo;
                    Console.WriteLine(resultDiv); 
                    break;
            }

            Console.ReadKey();
        }
    }
}
