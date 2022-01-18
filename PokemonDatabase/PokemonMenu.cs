using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
{
    public class PokemonMenu : Menu
    {
        private Pokemon pokemon;

        public PokemonMenu(int pokemonID)
        {
            pokemon = Program.database.GetPokemonById(pokemonID);

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
            Console.WriteLine("Name: " + pokemon.name);
            Console.WriteLine("Type: " + string.Join(", ", pokemon.types));
        }
    }
}
