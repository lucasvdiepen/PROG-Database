using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    [Serializable]
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

    [Serializable]
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

    [DataContract]
    public class Ability
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public bool isHidden { get; set; }
        [DataMember]
        public int slot { get; set; }

        public Ability(string name, bool isHidden)
        {
            this.name = name;
            this.isHidden = isHidden;
        }
    }

    public class Pokemon
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public List<PokemonType> types { get; set; }
        [DataMember]
        public List<Ability> abilities { get; set; }
        [DataMember]
        public Dictionary<PokemonStats, int> stats { get; set; }
        [DataMember]
        public float height { get; set; }
        [DataMember]
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

        public Pokemon(int id, string name, List<PokemonType> types, List<Ability> abilities, Dictionary<PokemonStats, int> stats, float height, float weight)
        {
            this.id = id;
            this.name = name;
            this.types = types;
            this.abilities = abilities;
            this.stats = stats;
            this.height = height;
            this.weight = weight;
        }
    }
}
