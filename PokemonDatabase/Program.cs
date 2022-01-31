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

            new Menus.MainMenu();
        }
    }
}
