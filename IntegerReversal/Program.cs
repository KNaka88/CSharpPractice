using System;
using System.Linq;

namespace IntegerReversal
{
    // --- Directions
    // Given an integer, return an integer that is the reverse
    // ordering of numbers.
    // --- Examples
    //   reverseInt(15) === 51
    //   reverseInt(981) === 189
    //   reverseInt(500) === 5
    //   reverseInt(-15) === -51
    //   reverseInt(-90) === -9
    class Program
    {
        static void Main(string[] args)
        {
            var num = -90;

            Console.WriteLine(ReverseInt(num));
        }

        public static int ReverseInt(int num)
        {
            var reversedStrNum = new string(Math.Abs(num).ToString().Reverse().ToArray());
            var reversedNum = Int32.Parse(reversedStrNum);

            return reversedNum * Math.Sign(num);
        }
    }
}
