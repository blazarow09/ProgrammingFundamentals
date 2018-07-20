using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var comand = Console.ReadLine().Split(' ').ToList();
            while (comand[0] != "print")
            {
                var pos = 0;
                var element = 0;
                var end = nums.Count;
                switch (comand[0])
                {
                    case "add":
                        pos = (int.Parse)(comand[1]);
                        if (pos > nums.Count)
                            break;
                        element = (int.Parse)(comand[2]);
                        nums.Insert(pos, element);
                        break;
                    case "addMany":
                        pos = (int.Parse)(comand[1]);
                        if (pos > nums.Count)
                            break;
                        for (int i = comand.Count - 1; i >= 2; i--)
                            nums.Insert(pos, (int.Parse)(comand[i]));
                        break;
                    case "contains":
                        element = (int.Parse)(comand[1]);
                        Console.WriteLine(nums.IndexOf(element));
                        break;
                    case "remove":
                        pos = (int.Parse)(comand[1]);
                        nums.RemoveAt(pos);
                        break;
                    case "shift":
                        pos = Shift(ref nums, comand);
                        break;
                    case "sumPairs":
                        SumPairs(ref nums, ref end);
                        break;
                    default: Console.WriteLine(); break;
                }
                comand = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine("[" + string.Join(", ", nums) + "]");

        }

        private static void SumPairs(ref List<double> nums, ref int end)
        {
            List<double> results = new List<double>();
            if (nums.Count % 2 != 0)
                end = nums.Count - 1;

            for (int i = 0; i < end; i += 2)
                results.Add(nums[i] + nums[i + 1]);
            if (nums.Count % 2 != 0)
                results.Add(nums.Last());
            nums = results;
        }

        private static int Shift(ref List<double> nums, List<string> comand)
        {
            int pos = (int.Parse)(comand[1]);
            var result = nums.Skip(pos).ToList();
            for (int i = 0; i < pos % nums.Count; i++)
                result.Add(nums[i]);
            nums = result;
            return pos;
        }
    }
}