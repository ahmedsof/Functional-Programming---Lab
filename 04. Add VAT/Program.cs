using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] nums = Console.ReadLine().Split(", ").Select(decimal.Parse)
                .Select(x => x * 1.2m).ToArray();

            foreach (var item in nums)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
