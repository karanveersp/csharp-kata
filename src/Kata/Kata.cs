using System;

namespace Kata
{
    public class Kata
    {
        /**
        Takes an array and moves all zeroes to the end,
        preserving the order of the other elements.
        O(n) solution
         */
        public static int[] MoveZeroes(int[] arr)
        {
            var result = new int[arr.Length];   // C# uses 0 as default values
            int j = 0;                          // index for result array

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    // assign non-zero value and increment j
                    result[j] = arr[i];
                    j++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            var result = MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1});
            Console.WriteLine("[{0}]", string.Join(", ", result));

            RiemannSum.usage();
        }
    }
}