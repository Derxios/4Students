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
            //SimpleCalculator();
            //SimpleCalculatorAlt();
            //InfinateNumberGame();
            //NumberGameLifes();
        }

        static void SimpleCalculator()
        {
            Console.Write("Gebe die erste Zahl ein: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gebe die zweite Zahl ein: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gebe den Operator ein: ");
            var _operator = Console.ReadLine();

            if (_operator == "+")
            {
                var result = numberOne + numberTwo;
                Console.WriteLine(result);
            }
            else if (_operator == "-")
            {
                var result = numberOne - numberTwo;
                Console.WriteLine(result);
            }
            else if (_operator == "*")
            {
                var result = numberOne * numberTwo;
                Console.WriteLine(result);
            }
            else if (_operator == "/")
            {
                var result = numberOne / numberTwo;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Fehler");
            }

            Console.ReadKey();
        }
        static void SimpleCalculatorAlt()
        {
            Console.Write("Gebe die erste Zahl ein: ");
            int.TryParse(Console.ReadLine(), out var numberOne);

            Console.Write("Gebe die zweite Zahl ein: ");
            int.TryParse(Console.ReadLine(), out var numberTwo);

            Console.Write("Gebe den Operator ein: ");
            char.TryParse(Console.ReadLine(), out var _operator);

            switch (_operator)
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
        static void InfinateNumberGame()
        {
            var rnd = new Random();
            int rndNumber = rnd.Next(100);
            int input;

            Console.WriteLine("Gib eine Zahl zwischen 0 und 100 ein:");

            do
            {
                int.TryParse(Console.ReadLine(), out input);

                if (rndNumber < input)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner.");
                }
                else if (rndNumber > input)
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer.");
                }

            } while (input != rndNumber);

            Console.WriteLine("Glückwunsch, du hast die Zahl erraten!");
            Console.ReadKey();
        }
        static void NumberGameLifes()
        {
            var rnd = new Random();
            int rndNumber = rnd.Next(100);
            int input;
            int lifes = 6;

            Console.WriteLine("Gib eine Zahl zwischen 0 und 100 ein:");

            do
            {
                int.TryParse(Console.ReadLine(), out input);

                if (rndNumber < input)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner.");
                    //lifes = lifes - 1;
                    //lifes -= 1;
                    //--lifes;
                }
                else if (rndNumber > input)
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer.");
                    //lifes = lifes - 1;
                    //lifes -= 1;
                    //--lifes;
                }
            } while (lifes > 0 && input != rndNumber);

            if (lifes == 0)
            {
                Console.WriteLine($"Alle Leben aufgebraucht, die Zahl war {rndNumber}");
            }
            else if (input == rndNumber)
            {
                Console.WriteLine("Glückwunsch, du hast die Zahl erraten!");
            }

            Console.ReadKey();

        }
    }
}
