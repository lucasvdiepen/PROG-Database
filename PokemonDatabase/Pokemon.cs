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

    public class Pokemon
    {
        public int id;
        public string name;
        public List<PokemonType> type;
        public PokemonStats stats;

        public Pokemon(int id, string name, List<PokemonType> type, PokemonStats stats)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.stats = stats;
        }
    }
}
