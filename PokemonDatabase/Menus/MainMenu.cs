using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase.Menus
{
    public class MainMenu : SelectMenu
    {
        public MainMenu() : base(new string[] { "Show all pokemons", "Add new pokemon", "Filter" })
        {

        }

        private protected override void PrintMenu()
        {
            Console.Clear();

            base.PrintMenu();
        }

        private protected override void Select(MenuItem menuItem)
        {
            switch(menuItem.itemName)
            {
                case "Show all pokemons":
                    break;
                case "Add new pokemon":
                    new AddPokemonMenu();
                    PrintMenu();
                    break;
                case "Filter":
                    new FilterMainMenu();
                    PrintMenu();
                    break;
            }
        }
    }
}
