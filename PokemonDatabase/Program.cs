using System;
using System.Collections.Generic;

namespace PokemonDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Pokedex database = new Pokedex();

            database.AddItem(new Pokemon(1, "Charizard", new List<PokemonType>() { PokemonType.Fire }, new PokemonStats(80, 75, 90, 50, 70, 40, 55)));
            database.AddItem(new Pokemon(2, "Blastoise", new List<PokemonType>() { PokemonType.Water }, new PokemonStats(75, 80, 80, 70, 65, 80, 75)));

            FilterSearchConfig.Setup();
            new FilterMainMenu();

            while(true)
            {
                database.RunInput();
            }
        }
    }
}
