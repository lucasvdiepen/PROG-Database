﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class Pokedex
    {
        private List<Pokemon> _items;

        public Pokedex()
        {
            _items = new List<Pokemon>();
        }

        public void InsertFromJson(string json)
        {

        }

        public void AddItem(Pokemon item)
        {
            _items.Add(item);
        }

        public List<Pokemon> GetAllItems()
        {
            return _items;
        }

        public void PrintAllItems()
        {
            foreach(Pokemon pokemon in GetAllItems())
            {
                Console.WriteLine(pokemon.name);
            }
        }

        public Pokemon GetPokemonById(int id)
        {
            for(int i = 0; i < _items.Count; i++)
            {
                if (_items[i].id == id) return _items[i];
            }

            return null;
        }

        public void RunInput()
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        PrintAllItems();
                        break;
                }
            }
        }
    }
}
