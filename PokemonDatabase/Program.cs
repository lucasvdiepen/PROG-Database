using System;
using System.Collections.Generic;
using System.IO;

namespace PokemonDatabase
{
    class Program
    {
        public static Pokedex database = new Pokedex();

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            database.InsertFromJson(File.ReadAllText("pokemons.json"));

            //database.AddItem(new Pokemon(1, "Charizard", new List<PokemonType>() { PokemonType.Fire }, new PokemonStats(80, 75, 90, 50, 70, 40, 55)));
            //database.AddItem(new Pokemon(2, "Blastoise", new List<PokemonType>() { PokemonType.Water }, new PokemonStats(75, 80, 80, 70, 65, 80, 75)));

            new FilterMainMenu();

            while(true)
            {
                database.RunInput();
            }
        }
    }
}
