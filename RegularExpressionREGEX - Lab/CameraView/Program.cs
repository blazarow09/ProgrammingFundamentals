using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sk = nums[0];
            int tk = nums[1];

            var pattern = "\\|<(\\w{" + sk + "})(\\w{0," + tk + "})";

            var input = Console.ReadLine();

            var matched = Regex.Matches(input, pattern);

            var res = new List<string>();

            foreach (Match m in matched)
            {
                res.Add(m.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", res));
        }
    }
}
