﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class FilterStatsMenu : SelectMenu
    {
        public FilterStatsMenu() : base(Enum.GetNames(typeof(PokemonStats)))
        {

        }

        private protected override void Select(MenuItem menuItem)
        {
            new FilterStatsOperatorMenu((PokemonStats)Enum.Parse(typeof(PokemonStats), menuItem.itemName));
        }

        private protected override void PrintMenu()
        {
            Console.Clear();

            base.PrintMenu();
        }
    }
}
