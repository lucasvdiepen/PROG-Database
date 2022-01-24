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

    public enum PokemonStats
    {
        TotalRating,
        HP,
        Attack,
        Defense,
        SpecialAttack,
        SpecialDefense,
        Speed
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
        public Dictionary<PokemonStats, int> stats { get; set; }
        public float height { get; set; }
        public float weight { get; set; }

        public int GetStat(PokemonStats pokemonStat)
        {
            if(pokemonStat == PokemonStats.TotalRating)
            {
                int count = 0;
                foreach (int currentStat in stats.Values.ToList())
                {
                    count += currentStat;
                }

                return count;
            }

            if(stats.TryGetValue(pokemonStat, out int stat))
            {
                return stat;
            }

            return -1;
        }
    }
}
