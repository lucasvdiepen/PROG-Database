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
                
                if(FilterType(pokemon))
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
            List<MenuItem> l = new List<MenuItem>();

            for (int i = 0; i < pokemons.Count; i++) l.Add(new MenuItem(pokemons[i].name, pokemons[i].id));

            return l.ToArray();
        }

        /*private bool FilterStats(Pokemon pokemon)
        {
            
        }*/

        private bool FilterType(Pokemon pokemon)
        {
            int count = 0;

            //Check types condition
            for (int i = 0; i < types.Count; i++)
            {
                if (pokemon.types.Contains(types[i]))
                {
                    count++;
                }
            }

            if (count == types.Count) return true;

            return false;
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
