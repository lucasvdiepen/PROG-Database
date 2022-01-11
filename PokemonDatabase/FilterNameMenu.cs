﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class FilterNameMenu : Menu
    {
        private string input = "";

        public FilterNameMenu()
        {
            PrintMenu();

            Setup();
        }

        public override void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Press enter to search");
            Console.WriteLine("");
            Console.Write("Name: ");
        }

        public override bool RunInput(ConsoleKeyInfo keyInfo)
        {
            switch(keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    Debug.WriteLine("Should search by name now");
                    break;
                case ConsoleKey.Backspace:
                    if(input.Length > 0)
                    {
                        Console.Write("\b \b");
                        input = input[0..^1];
                    }
                    break;
                default:
                    if(!char.IsControl(keyInfo.KeyChar))
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