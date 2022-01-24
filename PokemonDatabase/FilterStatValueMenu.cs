using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class FilterStatValueMenu : Menu
    {
        private string input = "";
        private PokemonStats stat;
        private string statOperator;
        

        public FilterStatValueMenu(PokemonStats stat, string statOperator)
        {
            this.stat = stat;
            this.statOperator = statOperator;

            Setup();
        }

        private protected override void Setup()
        {
            PrintMenu();

            base.Setup();
        }

        private protected override void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Press enter to add condition");
            Console.WriteLine("");
            Console.WriteLine("Stat: " + stat.ToString());
            Console.WriteLine("");
            Console.WriteLine("Operator: " + statOperator);
            Console.WriteLine("");
            Console.Write("Value: " + input);
        }

        private protected override bool RunInput(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Add new stat condition here");
                    PrintMenu();
                    break;
                case ConsoleKey.Backspace:
                    if (input.Length > 0)
                    {
                        Console.Write("\b \b");
                        input = input[0..^1];
                    }
                    break;
                default:
                    if (!char.IsControl(keyInfo.KeyChar) && char.IsNumber(keyInfo.KeyChar))
                    {
                        Console.Write(keyInfo.KeyChar);
                        input += keyInfo.KeyChar;
                    }
                    break;
            }

            return base.RunInput(keyInfo);
        }
    }
}
