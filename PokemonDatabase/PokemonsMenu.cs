using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class PokemonsMenu : SelectMenu
    {
        public PokemonsMenu(MenuItem[] items) : base(items)
        {
            
        }

        private protected override void PrintMenu()
        {
            Console.Clear();

            base.PrintMenu();
        }

        private protected override void Select(MenuItem menuItem)
        {
            new PokemonMenu(menuItem.id);
            PrintMenu();
        }
    }
}
