using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class MenuItem
    {
        public int id { get; set; }
        public string itemName { get; set; }

        public MenuItem(string itemName, int id = -1)
        {
            this.id = id;
            this.itemName = itemName;
        }
    }
}
