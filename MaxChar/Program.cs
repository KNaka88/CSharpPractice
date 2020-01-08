using System;
using System.Linq;

namespace MaxChar
{
    class Program
    {
        // --- Directions
        // Given a string, return the character that is most
        // commonly used in the string.
        // --- Examples
        // maxChar("abcccccccd") === "c"
        // maxChar("apple 1231111") === "1"
        static void Main(string[] args)
        {
            var str = "abcccccccd";

            Console.WriteLine(MaxChar(str));
        }

        static Char MaxChar(string str)
        {
            return str
                    .GroupBy(x => x)
                    .OrderByDescending(x => x.Count())
                    .First().Key;
        }
    }
}
