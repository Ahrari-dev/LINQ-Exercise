using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> gameNames = new List<string>()
        {
            "Minecraft",
            "Fortnite",
            "Call of Duty",
            "The Legend of Zelda",
            "Final Fantasy",
            "Super Mario Odyssey",
            "Assassin's Creed",
            "Grand Theft Auto",
            "Red Dead Redemption",
            "Overwatch"
        };

        Console.WriteLine("Original List:");
        foreach (string game in gameNames)
        {
            Console.WriteLine(game);
        }

        Console.WriteLine("\nOrdered List by Length of Game Name:");
        List<string> orderedGameNames = gameNames.OrderBy(game => game.Length).ToList();
        foreach (string game in orderedGameNames)
        {
            Console.WriteLine(game);
        }

        Console.ReadLine();
    }
}
