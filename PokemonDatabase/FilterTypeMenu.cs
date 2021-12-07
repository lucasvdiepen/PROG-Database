using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class FilterTypeMenu : Menu
    {
        private static string[] menuItems = Enum.GetNames(typeof(PokemonType));

        //Enter presses
        public override void Select(string menuItem)
        {
            PokemonType selectedType = (PokemonType)Enum.Parse(typeof(PokemonType), menuItem);

            if (FilterSearch.types.Contains(selectedType)) FilterSearch.types.Remove(selectedType);
            else FilterSearch.types.Add(selectedType);

            PrintMenu();
        }

        //Initialize
        public FilterTypeMenu() : base(menuItems)
        {

        }

        public override void PrintMenu()
        {
            Console.Clear();

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (selectedId == i) Console.Write(">");
                else Console.Write(" ");

                if (FilterSearch.types.Contains((PokemonType)Enum.Parse(typeof(PokemonType), menuItems[i]))) Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  " + menuItems[i]);
                Console.ResetColor();
            }
        }
    }
}
