using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CardGame.Functions
{
    public static class GenerateInput
    {
        /// <summary>
        /// Generates user input prompt
        /// </summary>
        /// <param name="selection"> The options to be selected</param>
        /// <param name="textOutput"> Text to be shown</param>
        public static char PlayerInput(string[] selection, string textOutput)
        {
            bool invalid = false;
            char action;
            byte selectionLength = Convert.ToByte(selection.Length);
            char[] validInput = new char[4] { '1', '2', '3', '4' };
            Console.WriteLine(PlayerInitiate.Line);
            do
            {
                if (invalid)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, please type a number shown left");
                }
                Console.WriteLine("Select {0}", textOutput);
                for(byte i = 0; i < selectionLength; i++)
                {
                    Console.WriteLine("{0}: {1}", i + 1, selection[i]);
                }
                action = Console.ReadKey().KeyChar;
                invalid = true;
            } while (!validInput.Any(x => x.Equals(action)));
            return action;
        }
    }
}
