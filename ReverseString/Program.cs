using System;
using System.Linq;

namespace ReverseString
{
    // --- Directions
    // Given a string, return a new string with the reversed
    // order of characters
    // --- Examples
    //   reverse('apple') === 'leppa'
    //   reverse('hello') === 'olleh'
    //   reverse('Greetings!') === '!sgniteerG'
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Greetings!";    
            Console.WriteLine(ReverseStr(str));
        }
        public static string ReverseStr(string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}
