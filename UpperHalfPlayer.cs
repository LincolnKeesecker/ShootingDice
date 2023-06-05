using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            int half = DiceSize / 2;
            return new Random().Next(half, DiceSize) + 1;
        }
    }
}