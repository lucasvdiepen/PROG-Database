using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class FilterSearchConfig
    {
        public List<PokemonType> types;
        public List<KeyValuePair<PokemonStats, int>> stats;

        public FilterSearchConfig()
        {
            Setup();
        }

        public MenuItem[] Search()
        {
            List<Pokemon> l = Program.database.GetAllItems();

            for (int i = l.Count - 1; i >= 0; i--)
            {
                Pokemon pokemon = l[i];
                
                if(FilterType(pokemon) && FilterStats(pokemon))
                {

                }
                else
                {
                    l.RemoveAt(i);
                }
            }

            return ToMenuItems(l);
        }

        private MenuItem[] ToMenuItems(List<Pokemon> pokemons)
        {
            
        }

        private bool FilterStats(Pokemon pokemon)
        {
            
        }

        private bool FilterType(Pokemon pokemon)
        {
            int count = 0;

            //Check types condition
            for (int i = 0; i < types.Count; i++)
            {
                if (!pokemon.types.Contains(types[i]))
                {
                    count++;
                }

                if (i == types.Count - 1)
                {
                    if (count != types.Count - 1) return false;
                }
            }

            return true;
        }

        public void Setup()
        {
            types = new List<PokemonType>();
            stats = new List<KeyValuePair<PokemonStats, int>>();
        }

        public void Reset()
        {
            Setup();
        }
    }
}
