namespace HighRollDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool is_playing = true;
            
            int player_roll;
            int computer_roll;
            int player_wins = 0;
            int computer_wins = 0;
            int ties = 0;

            Random random = new Random();

            while (is_playing)
            {
                player_roll = random.Next(1, 7);
                computer_roll = random.Next(1, 7);
                Console.WriteLine("---HIGH ROLL---");    
                Console.WriteLine($"Player rolled: {player_roll}");
                Console.WriteLine($"Computer rolled: {computer_roll}");
                if (computer_roll > player_roll)
                {
                    computer_wins += 1;
                    Console.WriteLine();
                    Console.WriteLine("Computer wins that round :(");
                } else if (computer_roll < player_roll)
                {
                    player_wins += 1;
                    Console.WriteLine();
                    Console.WriteLine("Player wins that round :)");
                } else
                {
                    ties += 1;
                    Console.WriteLine();
                    Console.WriteLine("It's a tie!");
                }
                Console.WriteLine();
                Console.Write($@"Player Wins: {player_wins}
Computer Wins: {computer_wins}
Ties: {ties}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press 'r' to roll the dice again");
                Console.WriteLine("Press 'q' to quit game ");
                Console.Write("Player choice: ");
                char player_input = Console.ReadKey().KeyChar;
                if (player_input.ToString() == "r")
                {
                    is_playing = true;
                    Console.Clear();

                }
                if (player_input.ToString() == "q")
                {
                    is_playing = false;
                    Console.Clear();
                    Console.WriteLine("---Thanks for playing!---");
                }
            }
            Console.ReadLine(); 
        }
    }
}