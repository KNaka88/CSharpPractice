using System;
using System.Linq;

namespace Steps
{
    // --- Directions
    // Write a function that accepts a positive number N.
    // The function should console log a step shape
    // with N levels using the # character.  Make sure the
    // step has spaces on the right hand side!
    // --- Examples
    //   steps(2)
    //       '# '
    //       '##'
    //   steps(3)
    //       '#  '
    //       '## '
    //       '###'
    //   steps(4)
    //       '#   '
    //       '##  '
    //       '### '
    //       '####'
    class Program
    {
        static void Main(string[] args)
        {
            var n = 5;

            Steps(n);
        }

        static void Steps(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                var steps = string.Concat(Enumerable.Repeat("#", i)) + string.Concat(Enumerable.Repeat(" ", n - i));
                Console.WriteLine(steps);
            }
        }
    }
}
