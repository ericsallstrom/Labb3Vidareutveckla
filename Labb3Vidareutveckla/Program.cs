﻿namespace Labb3Vidareutveckla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var machine = new WarmDrinkMachine(); // Skapar en instans av WarmDrinkMachine.
            IWarmDrink drink = machine.MakeDrink(); // Skapar en dryck.
            drink.Consume(); // Konsumerar drycken.
        }
    }
}
