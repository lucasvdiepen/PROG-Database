using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class FilterStatsOperatorMenu : SelectMenu
    {
        private PokemonStats stat;

        public FilterStatsOperatorMenu(PokemonStats stat) : base(new string[] { ">=", "<="})
        {
            this.stat = stat;
        }

        private protected override void Select(MenuItem menuItem)
        {
            new FilterStatValueMenu(stat, menuItem.itemName);
        }

        private protected override void PrintMenu()
        {
            Console.Clear();

            base.PrintMenu();
        }
    }
}
