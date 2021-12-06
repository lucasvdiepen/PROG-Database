using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public abstract class Menu
    {
        private string[] menuItems;
        private int selectedId;

        public abstract void Select();

        public void 

        public void RunInput()
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow or ConsoleKey.LeftArrow:
                        if (selectedId > 0) selectedId--;
                        break;
                    case ConsoleKey.DownArrow or ConsoleKey.RightArrow:
                        if (selectedId < menuItems.Length) selectedId++;
                        break;
                }
            }
        }
    }
}
