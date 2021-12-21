using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public abstract class Menu
    {
        internal MenuItem[] menuItems;
        internal int selectedId;

        public Menu(string[] menuItems)
        {
            MenuItem[] newMenuItems = new MenuItem[menuItems.Length];

            for(int i = 0; i < menuItems.Length; i++)
            {
                newMenuItems[i] = new MenuItem(menuItems[i]);
            }

            this.menuItems = newMenuItems;

            Setup();
        }

        public Menu(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;

            Setup();
        }

        private void Setup()
        {
            PrintMenu();
            StartMenu();
        }

        public abstract void Select(MenuItem menuItem);

        //Prints all menu items with arrow
        public virtual void PrintMenu()
        {
            for(int i = 0; i < menuItems.Length; i++)
            {
                if (selectedId == i) Console.Write(">");
                else Console.Write(" ");
                
                Console.WriteLine("   " + menuItems[i].itemName);
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
