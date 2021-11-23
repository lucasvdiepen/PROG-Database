using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class PokemonStats
    {
        public int totalRating;
        public int hp;
        public int attack;
        public int defense;
        public int spAttack;
        public int spDefense;
        public int speed;

        public PokemonStats(int totalRating, int hp, int attack, int defense, int spAttack, int spDefense, int speed)
        {
            this.totalRating = totalRating;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.spAttack = spAttack;
            this.spDefense = spDefense;
            this.speed = speed;
        }
    }
}
