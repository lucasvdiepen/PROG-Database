using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
            Pokemon[] pokemonsFromJson = JsonConvert.DeserializeObject<Pokemon[]>(json);

            _items.AddRange(pokemonsFromJson);
        }

        public void AddItem(Pokemon item)
        {
            _items.Add(item);
            SaveToJson();
        }

        public void RemoveItem(int id)
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

        private void SaveToJson()
        {
            string json = JsonConvert.SerializeObject(_items, new Newtonsoft.Json.Converters.StringEnumConverter());

            File.WriteAllText("pokemons.json", json);
        }

        public List<Pokemon> GetAllItems()
        {
            return new List<Pokemon>(_items);
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
    }
}
