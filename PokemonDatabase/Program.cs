using System;
using System.Collections.Generic;

namespace PokemonDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            database.AddItem(new Item("Charizard", PokemonType.Fire));
            database.AddItem(new Item("Blastoise" ,PokemonType.Water));

            List<Item> pokemons = database.GetAllItems();

            foreach(Item pokemon in pokemons)
            {
                Console.WriteLine(pokemon.name);
            }
        }
    }
}
