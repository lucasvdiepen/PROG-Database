using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase.Filter
{
    public static class FilterSearch
    {
        public static FilterSearchConfig config = new FilterSearchConfig();

        public static MenuItem[] SearchByName(string name)
        {
            List<Pokemon> pokemons = Pokedex.GetAllItems();
            List<MenuItem> menuItemsList = new List<MenuItem>();

            foreach(Pokemon pokemon in pokemons)
            {
                if(FindInString(pokemon.name, name))
                {
                    menuItemsList.Add(new MenuItem(pokemon.name, pokemon.id));
                }
            }

            return menuItemsList.ToArray();
        }

        public static MenuItem[] SearchByConfig()
        {
            return config.Search();
        }

        private static bool FindInString(string s, string input)
        {
            if(s.ToLower().Contains(input.ToLower()))
            {
                return true;
            }

            return false;
        }
    }
}
