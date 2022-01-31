using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PokemonDatabase
{
    public static class Pokedex
    {
        private static List<Pokemon> _items;

        public static void Setup()
        {
            _items = new List<Pokemon>();
        }

        public static void InsertFromJson(string json)
        {
            Pokemon[] pokemonsFromJson = JsonConvert.DeserializeObject<Pokemon[]>(json);

            _items.AddRange(pokemonsFromJson);
        }

        public static void AddItem(Pokemon item)
        {
            _items.Add(item);
            SaveToJson();
        }

        public static void RemoveItem(int id)
        {
            for(int i = 0; i < _items.Count; i++)
            {
                if(_items[i].id == id)
                {
                    _items.RemoveAt(i);
                    SaveToJson();
                    return;
                }
            }
        }

        private static void SaveToJson()
        {
            string json = JsonConvert.SerializeObject(_items, new Newtonsoft.Json.Converters.StringEnumConverter());

            File.WriteAllText("pokemons.json", json);
        }

        public static List<Pokemon> GetAllItems()
        {
            return new List<Pokemon>(_items);
        }

        public static void PrintAllItems()
        {
            foreach(Pokemon pokemon in GetAllItems())
            {
                Console.WriteLine(pokemon.name);
            }
        }

        public static Pokemon GetPokemonById(int id)
        {
            for(int i = 0; i < _items.Count; i++)
            {
                if (_items[i].id == id) return _items[i];
            }

            return null;
        }
    }
}
