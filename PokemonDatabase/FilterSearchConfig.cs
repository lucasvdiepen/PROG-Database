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
