﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public static class FilterSearchConfig
    {
        public static List<PokemonType> types;

        public static void Setup()
        {
            types = new List<PokemonType>();
        }
    }
}