using System;
using System.Linq;

namespace Capitalize
{
    // --- Directions
    // Write a function that accepts a string.  The function should
    // capitalize the first letter of each word in the string then
    // return the capitalized string.
    // --- Examples
    //   capitalize('a short sentence') --> 'A Short Sentence'
    //   capitalize('a lazy fox') --> 'A Lazy Fox'
    //   capitalize('look, it is working!') --> 'Look, It Is Working!'
    class Program
    {
        static void Main(string[] args)
        {
            var str = "look, it is working!";
            Console.WriteLine(CapitalizeFirstLetter(str));
        }

        static string CapitalizeFirstLetter(string str)
        {
            var resultArr = str.
                                Split(" ").
                                Select(s => Char.ToUpper(s[0]) + s.Substring(1)).
                                ToArray();
            return String.Join(" ", resultArr);
        }
    }
}
