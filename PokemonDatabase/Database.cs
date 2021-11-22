using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class Database
    {
        private List<Item> _items;

        public Database()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public List<Item> GetAllItems()
        {
            return _items;
        }
    }
}
