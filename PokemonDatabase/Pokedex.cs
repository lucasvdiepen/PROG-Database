using System;
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

        public void AddItem(Pokemon item)
        {
            _items.Add(item);
        }

        public List<Pokemon> GetAllItems()
        {
            return _items;
        }
    }
}
