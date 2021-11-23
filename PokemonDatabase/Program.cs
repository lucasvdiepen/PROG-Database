using System;
using System.Collections.Generic;

namespace PokemonDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex database = new Pokedex();

            database.AddItem(new Pokemon("Charizard", PokemonType.Fire));
            database.AddItem(new Pokemon("Blastoise", PokemonType.Water));

            List<Pokemon> pokemons = database.GetAllItems();

            foreach(Pokemon pokemon in pokemons)
            {
                Console.WriteLine(pokemon.name);
            }
        }
    }
}
