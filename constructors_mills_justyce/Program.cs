using System;

namespace constructors_mills_justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Game favGame = new Game("warframe", "mmorpg");// Game object initialized with values of my favorite game
            Console.WriteLine($"my favorite game is {favGame.title} and it's a {favGame.genre}");// prints title and genre of favGame Game object
            Game otherFavGame = new Game();// game object that isnt initialized
            Console.WriteLine($"my favorite game is {otherFavGame.title} and it's a {otherFavGame.genre}");// prints title and genre of otherFavGame Gmae object
        }
    }
}
