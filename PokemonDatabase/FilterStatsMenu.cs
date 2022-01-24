using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class FilterStatsMenu : SelectMenu
    {
        public FilterStatsMenu() : base(Enum.GetNames(typeof(PokemonStats)).Union(new string[] {"", "Show current conditions"}).ToArray())
        {

        }

        private protected override void Select(MenuItem menuItem)
        {
            if(Enum.TryParse<PokemonStats>(menuItem.itemName, out PokemonStats result))
            {
                FilterSearch.config.statTemp = result;
                new FilterStatsOperatorMenu();
                return;
            }

            switch(menuItem.itemName)
            {
                case "Show current conditions":
                    new FilterCurrentStatsMenu();
                    break;
            }
        }

        private protected override void PrintMenu()
        {
            Console.Clear();

            base.PrintMenu();
        }
    }
}
