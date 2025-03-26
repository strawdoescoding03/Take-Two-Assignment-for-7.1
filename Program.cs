namespace Take_Two__Assignment__for_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            int userWallet = 20,
                userBet,
                computerFlip;

            string
                coinFace,
                quit,
                playAgain;

            Random generator = new Random();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Introduction



            Console.WriteLine("Welcome to the Parkside Casino!");
            Console.WriteLine("===============================");
            Console.WriteLine("Today, you will participate in the Magical Coin Toss of Truth!");
            Console.WriteLine("Place your bet to get started!");
            Console.WriteLine();

            //Game Loop
            while (!done)
            {



                Console.WriteLine("You have " + userWallet.ToString("C"));
                Console.Write("Place your bet: ");
                while (!int.TryParse(Console.ReadLine(), out userBet))
                {
                    Console.WriteLine("That is an invalid bet! Please try again!");
                }

                while (userBet > userWallet || userBet <= 0)
                {
                    Console.WriteLine("That is an invalid bet! Please try again!");
                    int.TryParse(Console.ReadLine(), out userBet);
                }


                Console.WriteLine("Thank you for you bet!");
                Console.WriteLine();
                Console.WriteLine("Now it's time to predict the face of the coin!");
                Console.Write("Heads or Tails? ");
                coinFace = Console.ReadLine().ToLower();

                while (coinFace != "heads" && coinFace != "tails")
                {
                    Console.WriteLine("That is an invlaid guess: Please try again.");
                    coinFace = Console.ReadLine().ToLower();

                }

                computerFlip = generator.Next(3);

                if (computerFlip == 0 && coinFace == "tails")
                {
                    Console.WriteLine("You picked " + coinFace + "!");
                    Console.WriteLine("The computer picked tails!");
                    Console.WriteLine();
                    Console.WriteLine("You win!");
                    Console.WriteLine();

                    userWallet = (userBet + userWallet);
                }
                else if (computerFlip == 1 && coinFace == "heads")
                {
                    Console.WriteLine("You picked " + coinFace + "!");
                    Console.WriteLine("The computer picked heads!");
                    Console.WriteLine();
                    Console.WriteLine("You win!");
                    Console.WriteLine();

                    userWallet = (userBet + userWallet);
                }


                else
                {
                    Console.WriteLine("You picked " + coinFace + "!");

                    if (computerFlip == 0)
                    {
                        Console.WriteLine("The computer got tails!");
                        Console.WriteLine();
                        Console.WriteLine("You lose!");
                        Console.WriteLine();
                        userWallet = (userWallet - userBet);
                    }

                    else if (computerFlip == 1)
                    {
                        Console.WriteLine("The computer got heads!");
                        Console.WriteLine();
                        Console.WriteLine("You lose!");
                        Console.WriteLine();
                        userWallet = (userWallet - userBet);

                    }

                    else
                    {
                        Console.WriteLine("The computer got");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(". .");
                        Thread.Sleep(1000);
                        Console.WriteLine(". . .");
                        Thread.Sleep(1000);
                        Console.WriteLine("ROOSTER!");

                        Console.WriteLine("OH NO! THE ROOSTER STOLE ALL YOUR MONEY!");
                        userWallet = 0;
                    }



                }

                if (userWallet == 0)
                {
                    //Console.Beep(611, 500);
                    //Console.Beep(577, 500);

                    Console.WriteLine("You have run out of money! You have been kicked out of the casio!");
                    Console.WriteLine("Come back when you have more money!");




                    done = true;
                }



                if (userWallet != 0)

                {

                    Console.Write("Would You like to play again? ");
                    playAgain = Console.ReadLine().ToLower();

                    if (playAgain == "no")
                    {
                        Console.WriteLine("You have left the Casino!");

                        if (userWallet < 20)
                        {
                            Console.WriteLine("congratulations! You lost " + (20 - userWallet).ToString("C)") + " at the casino!");
                        }

                        else
                        {
                            Console.WriteLine("Congratulations! You won " + (-20 + userWallet).ToString("C") + " at the casino!");
                        }

                        done = true;

                    }
                }
            }
        }
    }
}
