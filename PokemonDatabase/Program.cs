using System;
using System.Collections.Generic;
using System.IO;

namespace PokemonDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Pokedex.Setup();
            Pokedex.InsertFromJson(File.ReadAllText("pokemons.json"));

            new Menus.MainMenu();
        }
    }
}
