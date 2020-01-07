using System;
using System.Linq;

namespace Palindrome
{
    // --- Directions
    // Given a string, return true if the string is a palindrome
    // or false if it is not.  Palindromes are strings that
    // form the same word if it is reversed. *Do* include spaces
    // and punctuation in determining if the string is a palindrome.
    // --- Examples:
    //   palindrome("abba") === true
    //   palindrome("abcdefg") === false
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPalindrom("pennep"));
        }

        public static bool CheckPalindrom(string str)
        {
            var reversedStr = new string(str.Reverse().ToArray());
            return str == reversedStr;
        }
    }
}
