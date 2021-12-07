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
        internal int selectedId;

        public Menu(string[] menuItems)
        {
            this.menuItems = menuItems;

            PrintMenu();
            StartMenu();
        }

        public abstract void Select(string menuItem);

        //Prints all menu items with arrow
        public virtual void PrintMenu()
        {
            for(int i = 0; i < menuItems.Length; i++)
            {
                if (selectedId == i) Console.Write(">");
                else Console.Write(" ");
                
                Console.WriteLine("   " + menuItems[i]);
            }
        }

        //Starts menu input read
        public void StartMenu()
        {
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    if (RunInput(Console.ReadKey(true).Key)) break;
                }
            }
        }

        //Checks standard menu input
        public virtual bool RunInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (selectedId > 0)
                    {
                        selectedId--;
                        PrintMenu();
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (selectedId < menuItems.Length - 1)
                    {
                        selectedId++;
                        PrintMenu();
                    }
                    break;
                case ConsoleKey.Enter:
                    Select(menuItems[selectedId]);
                    break;
                case ConsoleKey.Escape:
                    return true;
            }

            return false;
        }
    }
}
