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
            //BMICalculator();
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
        static void BMICalculator()
        {
            Console.Write("Gib dein Gewicht (kg) an: ");
            double.TryParse(Console.ReadLine(), out var weight);
            Console.Write("Gib deine Größe (m) an: ");
            double.TryParse(Console.ReadLine(), out var height);

            var bmi = weight / (height * height);

            if (bmi < 18.5)
            {
                Console.WriteLine($"Dein BMI ist {Math.Round(bmi, 1, MidpointRounding.AwayFromZero)}. Du bist untergewichtig.");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine($"Dein BMI ist {Math.Round(bmi, 1, MidpointRounding.AwayFromZero)} Du bist normalgewichtig.");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine($"Dein BMI ist {Math.Round(bmi, 1, MidpointRounding.AwayFromZero)} Du bist übergewichtig.");
            }
            else if (bmi >= 30 && bmi <= 34.9)
            {
                Console.WriteLine($"Dein BMI ist {Math.Round(bmi, 1, MidpointRounding.AwayFromZero)} Du hast Adipositas Grad 1.");
            }
            else if (bmi >= 35 && bmi <= 39.9)
            {
                Console.WriteLine($"Dein BMI ist {Math.Round(bmi, 1, MidpointRounding.AwayFromZero)} Du hast Adipositas Grad 2.");
            }

            Console.ReadKey();
        }
    }
}
