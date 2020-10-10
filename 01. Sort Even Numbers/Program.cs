using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(", ")
                .Select((nums) =>
                {
                    return int.Parse(nums);
                })
                .Where(x => x % 2 == 0)
                .OrderBy((int x) =>
                {
                    return x;
                })
                .ToArray();

            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
