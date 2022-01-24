using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class FilterStatsOperatorMenu : SelectMenu
    {
        public FilterStatsOperatorMenu() : base(new string[] { ">=", "<=" })
        {
            
        }

        private protected override void Setup()
        {
            base.Setup();
        }

        private protected override void Select(MenuItem menuItem)
        {
            new FilterStatValueMenu(menuItem.itemName);
            PrintMenu();
        }

        private protected override void PrintMenu()
        {
            Console.Clear();

            base.PrintMenu();
        }
    }
}
