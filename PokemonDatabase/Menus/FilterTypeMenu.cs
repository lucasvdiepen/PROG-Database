using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase.Menus
{
    public class FilterTypeMenu : SelectMenu
    {
        //Enter presses
        private protected override void Select(MenuItem menuItem)
        {
            PokemonType selectedType = (PokemonType)Enum.Parse(typeof(PokemonType), menuItem.itemName);

            if (FilterSearch.config.types.Contains(selectedType)) FilterSearch.config.types.Remove(selectedType);
            else FilterSearch.config.types.Add(selectedType);

            PrintMenu();
        }

        //Initialize
        public FilterTypeMenu() : base(Enum.GetNames(typeof(PokemonType)))
        {

        }

        private protected override void PrintMenu()
        {
            Console.Clear();

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (selectedId == i) Console.Write(">");
                else Console.Write(" ");

                if (FilterSearch.config.types.Contains((PokemonType)Enum.Parse(typeof(PokemonType), menuItems[i].itemName))) Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  " + menuItems[i].itemName);
                Console.ResetColor();
            }
        }
    }
}
