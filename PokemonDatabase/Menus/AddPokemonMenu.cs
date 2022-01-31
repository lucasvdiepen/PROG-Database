using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase.Menus
{
    class InputField
    {
        public string input { get; set; }
        public bool onlyNumeric { get; private set; }

        public InputField(bool onlyNumeric)
        {
            this.onlyNumeric = onlyNumeric;
        }
    }

    public class AddPokemonMenu : Menu
    {
        private InputField[] inputs = new InputField[11];
        private int[] numericInputs = { 0, 3, 4, 5, 6, 7, 8, 9, 10 };
        private int currentInput = 0;

        public AddPokemonMenu() : base()
        {
            Setup();
        }

        private protected override void Setup()
        {
            for (int i = 0; i < inputs.Length; i++) inputs[i] = new InputField(ContainsOnlyNumericId(i));

            PrintMenu();

            base.Setup();
        }

        private bool ContainsOnlyNumericId(int index)
        {
            for(int i = 0; i < numericInputs.Length; i++)
            {
                if (numericInputs[i] == index) return true;
            }

            return false;
        }

        private protected override void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Add new pokemon");
            Console.WriteLine("");
            Console.WriteLine("Separate types with ,");
            Console.WriteLine("");
            Console.WriteLine("Id: " + inputs[0].input);
            Console.WriteLine("");
            Console.WriteLine("Name: " + inputs[1].input);
            Console.WriteLine("");
            Console.WriteLine("Types: " + inputs[2].input);
            Console.WriteLine("");
            Console.WriteLine("HP: " + inputs[3].input);
            Console.WriteLine("");
            Console.WriteLine("Attack: " + inputs[4].input);
            Console.WriteLine("");
            Console.WriteLine("Defense: " + inputs[5].input);
            Console.WriteLine("");
            Console.WriteLine("Special Attack: " + inputs[6].input);
            Console.WriteLine("");
            Console.WriteLine("Special Defense: " + inputs[7].input);
            Console.WriteLine("");
            Console.WriteLine("Speed: " + inputs[8].input);
            Console.WriteLine("");
            Console.WriteLine("Height: " + inputs[9].input);
            Console.WriteLine("");
            Console.WriteLine("Weight: " + inputs[10].input);
        }

        private protected override bool RunInput(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    currentInput++;
                    if (currentInput >= inputs.Length)
                    {

                        List<Ability> newAbilities = new List<Ability>();

                        //Create new stats dictionary
                        Dictionary<PokemonStats, int> newStats = new Dictionary<PokemonStats, int>();
                        newStats.Add(PokemonStats.HP, int.Parse(inputs[3].input));
                        newStats.Add(PokemonStats.Attack, int.Parse(inputs[4].input));
                        newStats.Add(PokemonStats.Defense, int.Parse(inputs[5].input));
                        newStats.Add(PokemonStats.SpecialAttack, int.Parse(inputs[6].input));
                        newStats.Add(PokemonStats.SpecialDefense, int.Parse(inputs[7].input));
                        newStats.Add(PokemonStats.Speed, int.Parse(inputs[8].input));

                        //Add pokemon here
                        Pokedex.AddItem(new Pokemon(int.Parse(inputs[0].input), inputs[1].input, StringArrayToPokemonTypes(inputs[2].input.Split(",")), newAbilities, newStats, float.Parse(inputs[9].input), float.Parse(inputs[10].input)));

                        return true;
                    }
                    break;
                case ConsoleKey.Backspace:
                    if (inputs[currentInput].input.Length > 0)
                    {
                        //Console.Write("\b \b");
                        inputs[currentInput].input = inputs[currentInput].input[0..^1];

                        PrintMenu();
                    }
                    break;
                default:
                    if (!char.IsControl(keyInfo.KeyChar))
                    {
                        //Console.Write(keyInfo.KeyChar);

                        if (inputs[currentInput].onlyNumeric && !char.IsNumber(keyInfo.KeyChar)) break;

                        inputs[currentInput].input += keyInfo.KeyChar;

                        PrintMenu();
                    }
                    break;
            }

            return base.RunInput(keyInfo);
        }

        private List<PokemonType> StringArrayToPokemonTypes(string[] list)
        {
            List<PokemonType> newTypes = new List<PokemonType>();
            foreach (string inputType in list)
            {
                newTypes.Add((PokemonType)Enum.Parse(typeof(PokemonType), inputType.Trim(), true));
            }

            return newTypes;
        }
    }
}
