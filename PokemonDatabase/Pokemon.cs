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

    public class Ability
    {
        public string name { get; set; }
        public bool isHidden { get; set; }
        public int slot { get; set; }
    }

    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<PokemonType> types { get; set; }
        public List<Ability> abilities { get; set; }
        public PokemonStats stats { get; set; }
        public float height { get; set; }
        public float weight { get; set; }

        /*public Pokemon(int id, string name, List<PokemonType> types, PokemonStats stats)
        {
            this.id = id;
            this.name = name;
            this.types = types;
            this.stats = stats;
        }*/
    }
}
