using System;
using System.Media;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to the game 21! Let's Start!");
                string[] array = new string[9] { "ace", "king", "lady", "jack", "10", "9", "8", "7", "6" };
                string yourCards = "";
                string computerCards = "";
                Random rnd = new Random();
                int yourScore = 0;
                int computerScore = 0;
                Console.WriteLine(Console.ForegroundColor);
                do
                {
                    int yourCard = rnd.Next(0, 8);
                    int computerCard = rnd.Next(0, 8);
                    yourScore += ScorePlus(yourCard);
                    yourCards = yourCards + " " + array[yourCard];
                    computerScore += ScorePlus(computerCard);
                    computerCards = computerCards + " " + array[computerCard];
                    Console.Clear();
                    Console.WriteLine("yourCards: " + yourCards + ". Your score = " + yourScore);
                    // Console.WriteLine("computerCards: " + computerCards + ". Computer score = " + computerScore);
                    if (yourScore > 21 && computerScore > 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("DRAW! Try again!");
                        Console.WriteLine("computerCards: " + computerCards + ". Computer score = " + computerScore);
                        Console.ReadLine();
                        return;
                    }

                    if (yourScore == 21 && computerScore == 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("DRAW! Try again!");
                        Console.ReadLine();
                        Console.WriteLine("computerCards: " + computerCards + ". Computer score = " + computerScore);
                        return;


                    }
                    if (computerScore == 21 || yourScore > 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Oh... Not your day =)");
                        Console.WriteLine("computerCards: " + computerCards + ". Computer score = " + computerScore);
                        Console.ReadLine();
                        return;
                    }

                    if (yourScore == 21 || computerScore > 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You WIN");
                        Console.WriteLine("computerCards: " + computerCards + ". Computer score = " + computerScore);
                        Console.ReadLine();
                        return;
                    }

                    Console.WriteLine("If you want to take card, press 'ENTER'. If you want to stop the game, press 'SPACE' ");
                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        if (yourScore == computerScore)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("DRAW! Try again!");
                            Console.WriteLine("computerCards: " + computerCards + ". Computer score = " + computerScore);
                            Console.ReadLine();
                            return;
                        }

                        if (yourScore > computerScore)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You WIN");
                            Console.WriteLine("computerCards: " + computerCards + ". Computer score = " + computerScore);
                            Console.ReadLine();
                            return;
                        }

                        if (yourScore < computerScore)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Oh... Not your day =)");
                            Console.WriteLine("computerCards: " + computerCards + ". Computer score = " + computerScore);
                            Console.ReadLine();
                            return;
                        }

                        return;
                    }
                } while (Console.ReadKey(true).Key == ConsoleKey.Enter);
                Console.Clear();
            } while (Console.ReadKey(true).Key == ConsoleKey.Backspace);

            Console.WriteLine("Error! Only SPACE & ENTER!");
            Console.ReadKey();
            return;
        }

        public static int ScorePlus(int k)
        {
            int[] array = new int[9] { 11, 4, 3, 2, 10, 9, 8, 7, 6 };
            return (array[k]);
        }
    }
}
