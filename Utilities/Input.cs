using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RogueLike.Utilities
{
    class Input
    {
        public static int IntCapturer()
        {
            string input = Console.ReadLine();
            int output;

            while (!int.TryParse(input, out output))
            {
                input = Console.ReadLine();
            }
            return output;
        }

        public static char KeyInput(char[] keys)
        {
            char input = Console.ReadKey().KeyChar;

            while (!keys.Contains(input))
            {
                input = Console.ReadKey().KeyChar;
            }
            return input;
        }
    }
}
