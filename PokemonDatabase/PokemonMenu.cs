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
            Console.WriteLine("");
            Console.WriteLine("Id: " + pokemon.id);
            Console.WriteLine("");
            Console.WriteLine("Type: " + string.Join(", ", pokemon.types));
            Console.WriteLine("");
            Console.WriteLine("Height: " + pokemon.height);
            Console.WriteLine("");
            Console.WriteLine("Weight: " + pokemon.weight);
            Console.WriteLine("");
            Console.WriteLine("Stats:");
            Console.WriteLine("");
            foreach(PokemonStats stat in Enum.GetValues(typeof(PokemonStats)).Cast<PokemonStats>())
            {
                Console.WriteLine(stat.ToString() + ": " + pokemon.GetStat(stat));
            }

            Console.WriteLine("");
            Console.WriteLine("Abilities:");
            Console.WriteLine("");
            foreach (Ability ability in pokemon.abilities)
            {
                Console.WriteLine(ability.name + ". Is Hidden: " + ability.isHidden);
            }
        }
    }
}
