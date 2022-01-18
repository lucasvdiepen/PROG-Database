using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public abstract class SelectMenu : Menu
    {
        private protected MenuItem[] menuItems;
        private protected int selectedId;

        public SelectMenu(string[] menuItems)
        {
            if(menuItems != null && menuItems.Length <= 0) return;

            //Convert string array to menu items
            MenuItem[] newMenuItems = new MenuItem[menuItems.Length];

            for (int i = 0; i < menuItems.Length; i++)
            {
                newMenuItems[i] = new MenuItem(menuItems[i]);
            }

            this.menuItems = newMenuItems;

            Setup();
        }

        public SelectMenu(MenuItem[] menuItems)
        {
            if(menuItems != null && menuItems.Length <= 0) return;

            this.menuItems = menuItems;

            Setup();
        }

        private protected override void Setup()
        {
            PrintMenu();

            base.Setup();
        }

        private protected abstract void Select(MenuItem menuItem);

        //Prints all menu items with arrow
        private protected override void PrintMenu()
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (selectedId == i) Console.Write(">");
                else Console.Write(" ");

                Console.WriteLine("   " + menuItems[i].itemName);
            }
        }

        private protected override bool RunInput(ConsoleKeyInfo keyInfo)
        {
            switch(keyInfo.Key)
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
            }

            return base.RunInput(keyInfo);
        }
    }
}
