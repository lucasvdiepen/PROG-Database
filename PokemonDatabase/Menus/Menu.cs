using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase.Menus
{
    public abstract class Menu
    {
        private protected virtual void Setup()
        {
            StartMenu();
        }

        //Starts menu input read
        private void StartMenu()
        {
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    if (RunInput(Console.ReadKey(true))) break;
                }
            }
        }

        private protected abstract void PrintMenu();

        //Checks standard menu input
        private protected virtual bool RunInput(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.Escape:
                    return true;
            }

            return false;
        }
    }
}
