using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class FilterTypeMenu : Menu
    {
        //Enter presses
        public override void Select(MenuItem menuItem)
        {
            PokemonType selectedType = (PokemonType)Enum.Parse(typeof(PokemonType), menuItem.itemName);

            if (FilterSearch.types.Contains(selectedType)) FilterSearch.types.Remove(selectedType);
            else FilterSearch.types.Add(selectedType);

            PrintMenu();
        }

        //Initialize
        public FilterTypeMenu() : base(Enum.GetNames(typeof(PokemonType)))
        {

        }

        public override void PrintMenu()
        {
            Console.Clear();

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (selectedId == i) Console.Write(">");
                else Console.Write(" ");

                if (FilterSearch.types.Contains((PokemonType)Enum.Parse(typeof(PokemonType), menuItems[i].itemName))) Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  " + menuItems[i].itemName);
                Console.ResetColor();
            }
        }
    }
}
