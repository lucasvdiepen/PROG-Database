using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    class FilterStatsMenu : SelectMenu
    {
        public FilterStatsMenu() : base(Enum.GetNames(typeof(PokemonStats)))
        {

        }

        private protected override void Select(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        private protected override void PrintMenu()
        {
            Console.Clear();

            base.PrintMenu();
        }
    }
}
