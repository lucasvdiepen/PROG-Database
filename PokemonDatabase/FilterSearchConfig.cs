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

        public FilterSearchConfig()
        {
            Setup();
        }

        public MenuItem[] Search()
        {
            List<Pokemon> pokemons = Program.database.GetAllItems();
            List<MenuItem> l = new List<MenuItem>();

            foreach (Pokemon pokemon in pokemons)
            {
                //Check types condition
                for (int i = 0; i < types.Count; i++)
                {
                    if (!pokemon.types.Contains(types[i])) break;

                    if (i == types.Count) l.Add(new MenuItem(pokemon.id.ToString()));
                }
            }

            return l.ToArray();
        }

        public void Setup()
        {
            types = new List<PokemonType>();
        }

        public void Reset()
        {
            Setup();
        }
    }
}
