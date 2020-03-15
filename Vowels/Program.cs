using System;
using System.Text.RegularExpressions;

namespace Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "This is not my IDEA";
            var rx = new Regex(@"[aeiou]", RegexOptions.IgnoreCase);
            Console.WriteLine(rx.Matches(str).Count);
        }
    }
}
