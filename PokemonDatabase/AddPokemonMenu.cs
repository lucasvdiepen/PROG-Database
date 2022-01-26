using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDatabase
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
        private InputField[] inputs = new InputField[2];
        private int[] numericInputs = { 0 };
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
            Console.WriteLine("Id: " + inputs[0].input);
            Console.WriteLine("");
            Console.WriteLine("Name: " + inputs[1].input);
        }

        private protected override bool RunInput(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    currentInput++;
                    if (currentInput >= inputs.Length)
                    {
                        //Add pokemon here
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
    }
}
