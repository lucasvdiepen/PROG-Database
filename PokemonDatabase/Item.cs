using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public enum PokemonType
    {
        Normal, 
        Fire, 
        Water, 
        Grass, 
        Flying, 
        Fighting, 
        Poison, 
        Electric, 
        Ground, 
        Rock, 
        Psychic,
        Ice, 
        Bug, 
        Ghost, 
        Steel, 
        Dragon, 
        Dark,
        Fairy
    }

    public class Item
    {
        public string name;
        public PokemonType type;

        public Item(string name, PokemonType type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
