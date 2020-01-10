using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Chunk
{
    // --- Directions
    // Given an array and chunk size, divide the array into many subarrays
    // where each subarray is of length size
    // --- Examples
    // chunk([1, 2, 3, 4], 2) --> [[ 1, 2], [3, 4]]
    // chunk([1, 2, 3, 4, 5], 2) --> [[ 1, 2], [3, 4], [5]]
    // chunk([1, 2, 3, 4, 5, 6, 7, 8], 3) --> [[ 1, 2, 3], [4, 5, 6], [7, 8]]
    // chunk([1, 2, 3, 4, 5], 4) --> [[ 1, 2, 3, 4], [5]]
    // chunk([1, 2, 3, 4, 5], 10) --> [[ 1, 2, 3, 4, 5]]
    class Program
    {
        static void Main(string[] args)
        {
            var size = 3;
            var arr = new List<int> {1, 2, 3, 4, 5, 6, 7, 8};

            var results = Chunk(arr, size);
            
            Console.WriteLine(JsonSerializer.Serialize(results));
        }

        static IEnumerable<IEnumerable<TSource>> Chunk<TSource>(IEnumerable<TSource> source, int chunkSize)
        {
            for (var i = 0; i < source.Count(); i += chunkSize)
                yield return source.Skip(i).Take(chunkSize);
        } 
    }
}
