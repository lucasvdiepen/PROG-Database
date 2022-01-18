using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class FilterMainMenu : SelectMenu
    {
        //Enter presses
        private protected override void Select(MenuItem menuItem)
        {
            switch(menuItem.itemName)
            {
                case "Name":
                    new FilterNameMenu();
                    PrintMenu();
                    break;
                case "Type":
                    new FilterTypeMenu();
                    PrintMenu();
                    break;
                case "Reset":
                    FilterSearch.config.Reset();
                    break;
            }
        }

        //Initialize
        public FilterMainMenu() : base(new string[] { "Name", "Type", "Reset" })
        {

        }

        //Extra prints for this menu
        private protected override void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Press f to search\n");

            base.PrintMenu();
        }

        //Extra input for this menu
        private protected override bool RunInput(ConsoleKeyInfo keyInfo)
        {
            switch(keyInfo.Key)
            {
                case ConsoleKey.F:
                    new PokemonsMenu(FilterSearch.SearchByConfig());
                    PrintMenu();
                    break;
            }

            return base.RunInput(keyInfo);
        }
    }
}
