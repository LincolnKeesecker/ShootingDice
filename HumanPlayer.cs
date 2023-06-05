using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Please enter a number: ");
            string response = Console.ReadLine();
            int parsedResponse = Int32.Parse(response);
            return parsedResponse;
        }
    }
}