using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class MenuItem
    {
        public int id { get; private set; }
        public string itemName { get; private set; }

        public MenuItem(string itemName, int id = -1)
        {
            this.id = id;
            this.itemName = itemName;
        }
    }
}
