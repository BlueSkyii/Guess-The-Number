namespace GuessTheNumber
{
    internal class RandomNumberGame
    {
        private int num;
        private Random randomNum = new Random();

        public void GameStart()
        {
            int count = 1;
            int num2 = randomNum.Next(0, 26);

            Console.WriteLine("Guess The Number Between (0-25)");
            Console.WriteLine("===============================");
            Console.WriteLine("You Only Have 5 Chances!");
            Console.WriteLine("===============================");

            while (num != num2)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Enter Number: ");
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nInvalid Input Try Again!\n");
                        continue;
                    }

                    if (num >= 0 && num <= 25)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input The Number Is Between (0-25)");
                        continue;
                    }
                }

                if (count == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou Used All Of Your Chances!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"The Number Was: {num2}");
                    break;
                }
                else if (num < num2)
                {
                    Console.WriteLine("\nYour Number Is Less Than It\n");
                    ++count;
                    continue;
                }
                else if (num > num2)
                {
                    Console.WriteLine("\nYour Number Is Greater Than It\n");
                    ++count;
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nCorrect Answer!!!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
    }
}
