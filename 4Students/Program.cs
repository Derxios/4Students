using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _4Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Projekttage St.Ursula 02.12. & 03.12.2024");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Projektauswahl");
                Console.WriteLine("1 - Taschenrechner\n2 - Zahlenratespiel (6-Leben-Modus)\n3 - Zahlenratespiel (Endlosmodus)\n4 - BMI-Rechner\n5 - Stoppuhr\n6 - Schere-Stein-Papier\n7 - Quiz");
                Console.WriteLine("-------------------------------------------------------------------");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        //SimpleCalculator();
                        //SimpleCalculatorAlt();
                        break;
                    case "2":
                        Console.Clear();
                        NumberGameLifes();
                        break;
                    case "3":
                        Console.Clear();
                        InfiniteNumberGame();
                        break;
                    case "4":
                        Console.Clear();
                        BMICalculator();
                        break;
                    case "5":
                        Console.Clear();
                        Stopwatch();
                        break;
                    case "6":
                        Console.Clear();
                        RockPaperScissors();
                        break;
                    case "7":
                        Console.Clear();
                        Quiz();
                        break;
                    default:
                        break;
                };
            }
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

            Console.WriteLine("Beliebige Taste drücken");
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
            Console.WriteLine("Beliebige Taste drücken");
            Console.ReadKey();
        }
        static void InfiniteNumberGame()
        {
            var rnd = new Random();
            int rndNumber = rnd.Next(100);
            int input;

            Console.WriteLine("Gib eine Zahl zwischen 0 und 100 ein:");
            Console.WriteLine("'999' - Menü");

            do
            {
                int.TryParse(Console.ReadLine(), out input);
                if (input == 999)
                {
                    Console.Clear();
                    Console.WriteLine("Beliebige Taste drücken.");
                    break;
                }
                if (input >= 0 && input <= 100)
                {
                    if (rndNumber < input)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist kleiner.");
                        Console.WriteLine("'999' um aufzugeben.");
                    }
                    else if (rndNumber > input)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist größer.");
                        Console.WriteLine("'999' um aufzugeben.");
                    }
                }
                else 
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    Console.WriteLine("'999' um aufzugeben.");
                }
            } while (input != rndNumber);

            if (input == rndNumber) Console.WriteLine("Glückwunsch, du hast die Zahl erraten!");
            Console.ReadKey();
        }
        static void NumberGameLifes()
        {
            var rnd = new Random();
            int rndNumber = rnd.Next(100);
            int input;
            int lifes = 6;

            Console.WriteLine("Gib eine Zahl zwischen 0 und 100 ein:");
            Console.WriteLine("'999' - Menü");

            do
            {
                int.TryParse(Console.ReadLine(), out input);
                if (input == 999)
                {
                    Console.Clear();
                    Console.WriteLine("Beliebige Taste drücken.");
                    break;
                }
                if (input >= 0 && input <= 100)
                {
                    if (rndNumber < input)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist kleiner.");
                        Console.WriteLine("'999' um aufzugeben.");
                        //lifes = lifes - 1;
                        lifes -= 1;
                        //--lifes;
                    }
                    else if (rndNumber > input)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist größer.");
                        Console.WriteLine("'999' um aufzugeben.");
                        //lifes = lifes - 1;
                        lifes -= 1;
                        //--lifes;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    Console.WriteLine("'999' um aufzugeben.");
                    lifes -= 1;
                }
            } while (lifes > 0 && input != rndNumber);

            if (lifes == 0)
            {
                Console.WriteLine($"Alle Leben aufgebraucht, die Zahl war {rndNumber}");
            }
            if (input == rndNumber)
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
            Console.WriteLine("Beliebige Taste drücken");
            Console.ReadKey();
        }
        static void Stopwatch()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Uhr läuft. Drücke eine beliebige Taste zum stoppen.");
            Console.ReadKey();
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            string elapsedMessage = $"Aufgezeichnete Zeit: {timeSpan.Hours}h {timeSpan.Minutes}min {timeSpan.Seconds}s";
            Console.WriteLine(elapsedMessage);

            Console.WriteLine("Beliebige Taste drücken");
            Console.ReadKey();
        }
        static void RockPaperScissors()
        {
            int input;
            Console.WriteLine("Schere - 1 \nStein - 2 \nPapier - 3");
            int.TryParse(Console.ReadLine(), out input);
            var rnd = new Random();
            var rndNumber = rnd.Next(1, 3);
            string enemyChoice;
            Console.WriteLine("Schere");
            Thread.Sleep(1000);
            Console.WriteLine("Stein");
            Thread.Sleep(1000);
            Console.WriteLine("Papier!");
            Thread.Sleep(1000);

            if (input == 1)
            {
                if (rndNumber == 1) 
                {
                    enemyChoice = "Schere";
                    Console.WriteLine($"Der Computer hat {enemyChoice} gewählt. Unentschieden!");
                    Console.WriteLine("Beliebige Taste drücken");
                }
                if (rndNumber == 2) 
                {
                    enemyChoice = "Stein";
                    Console.WriteLine($"Der Computer hat {enemyChoice} gewählt. Verloren!");
                    Console.WriteLine("Beliebige Taste drücken");
                }
                if (rndNumber == 3)
                {
                    enemyChoice = "Papier";
                    Console.WriteLine($"Der Computer hat {enemyChoice} gewählt. Gewonnen!");
                    Console.WriteLine("Beliebige Taste drücken");
                }
            }
            if (input == 2)
            {
                if (rndNumber == 1)
                {
                    enemyChoice = "Schere";
                    Console.WriteLine($"Der Computer hat {enemyChoice} gewählt. Gewonnen!");
                    Console.WriteLine("Beliebige Taste drücken");
                }
                if (rndNumber == 2)
                {
                    enemyChoice = "Stein";
                    Console.WriteLine($"Der Computer hat {enemyChoice} gewählt. Unentschieden!");
                    Console.WriteLine("Beliebige Taste drücken");
                }
                if (rndNumber == 3)
                {
                    enemyChoice = "Papier";
                    Console.WriteLine($"Der Computer hat {enemyChoice} gewählt. Verloren!");
                    Console.WriteLine("Beliebige Taste drücken");
                }
            }
            if (input == 3)
            {
                if (rndNumber == 1)
                {
                    enemyChoice = "Schere";
                    Console.WriteLine($"Der Computer hat {enemyChoice} gewählt. Verloren!");
                    Console.WriteLine("Beliebige Taste drücken");
                }
                if (rndNumber == 2)
                {
                    enemyChoice = "Stein";
                    Console.WriteLine($"Der Computer hat {enemyChoice} gewählt. Gewonnen!");
                    Console.WriteLine("Beliebige Taste drücken");
                }
                if (rndNumber == 3)
                {
                    enemyChoice = "Papier";
                    Console.WriteLine($"Der Computer hat {enemyChoice} gewählt. Unentschieden!");
                    Console.WriteLine("Beliebige Taste drücken");
                }
            }
            Console.ReadKey();
        }
        static void Quiz()
        {
            int points = 0;
            var fragen = new List<string>{
                "In welchem Jahr der Mauerfall?",
                "Was ist die Hauptsadt von Südkorea?",
                "Wie viele Beine hat eine Spinne?",
                "Wie viele Farben hat der Regenbogen?",
                "Wie viele Kontinente gibt es auf der Welt?"
            };

            Console.WriteLine(fragen[0]);
            if (Console.ReadLine() == "1989")
            {
                ++points;
            }
            Console.Clear();

            Console.WriteLine(fragen[1]);
            if (Console.ReadLine() == "Seoul")
            {
                ++points;
            }
            Console.Clear();

            Console.WriteLine(fragen[2]);
            if (Console.ReadLine() == "8")
            {
                ++points;
            }
            Console.Clear();

            Console.WriteLine(fragen[3]);
            if (Console.ReadLine() == "7")
            {
                ++points;
            }
            Console.Clear();

            Console.WriteLine(fragen[4]);
            if (Console.ReadLine() == "7")
            {
                ++points;
            }
            Console.Clear();

            Console.WriteLine($"Quiz vorbei! Punkte erzielt: {points}/5.");
            Console.WriteLine("Beliebige Taste drücken");
            Console.ReadKey();
        }
    }
}
