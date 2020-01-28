using System;
using System.Linq;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 10;
            Pyramid(n);
        }

        static void Pyramid(int n)
        {
            var neededLength = n * 2 - 1;

            for (var i = 1; i <= n; i++)
            {
                var hash = string.Concat(Enumerable.Repeat("#", i * 2 - 1));
                var space = string.Concat(Enumerable.Repeat(" ", neededLength - (i * 2 - 1) / 2));
                Console.WriteLine(space + hash + space);               
            }
        }
    }
}
