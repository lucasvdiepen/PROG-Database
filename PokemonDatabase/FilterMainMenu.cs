using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class FilterMainMenu : Menu
    {
        //Enter presses
        public override void Select(MenuItem menuItem)
        {
            switch(menuItem.itemName)
            {
                case "Name":
                    Debug.WriteLine("Name was selected");
                    break;
                case "Type":
                    new FilterTypeMenu();
                    PrintMenu();
                    break;
            }
        }

        //Initialize
        public FilterMainMenu() : base(new string[] { "Name", "Type" })
        {

        }

        //Extra prints for this menu
        public override void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Press f to search\n");

            base.PrintMenu();
        }

        //Extra input for this menu
        public override bool RunInput(ConsoleKey key)
        {
            switch(key)
            {
                case ConsoleKey.F:
                    Debug.WriteLine("Should search now");
                    break;
            }

            return base.RunInput(key);
        }
    }
}
