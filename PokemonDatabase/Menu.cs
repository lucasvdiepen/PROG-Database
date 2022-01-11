using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public abstract class Menu
    {
        public virtual void Setup()
        {
            StartMenu();
        }

        //Starts menu input read
        public void StartMenu()
        {
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    if (RunInput(Console.ReadKey(true))) break;
                }
            }
        }

        public abstract void PrintMenu();

        //Checks standard menu input
        public virtual bool RunInput(ConsoleKeyInfo keyInfo)
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
