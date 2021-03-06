using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase.Menus
{
    public class FilterCurrentStatsMenu : SelectMenu
    {
        public FilterCurrentStatsMenu() : base(Filter.FilterSearch.config.GetAllStatConditions())
        {

        }

        private protected override void Select(MenuItem menuItem)
        {
            Filter.FilterSearch.config.stats.RemoveAt(menuItem.id);

            menuItems = Filter.FilterSearch.config.GetAllStatConditions();
            if (selectedId >= menuItems.Length) selectedId = menuItems.Length - 1;

            PrintMenu();
        }

        private protected override void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Press enter to delete condition");
            Console.WriteLine("");

            base.PrintMenu();
        }
    }
}
