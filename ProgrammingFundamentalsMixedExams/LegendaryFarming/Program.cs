using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split()
                .ToList();

            var legendary = new Dictionary<string, int>();
            var junk = new Dictionary<string, int>();
            bool stopProgram = false;
            var win = "";

            while (stopProgram == false)
            {


                var count = 1;
                for (int i = 0; i < input.Count; i += 2)
                {
                    var material = input[count];
                    var value = int.Parse(input[i]);
                    if (i % 2 == 0)
                    {
                        if (material == "shards" || material == "fragments" || material == "motes")
                        {
                            if (!legendary.ContainsKey(material))
                            {
                                legendary.Add(material, value);
                                count += 2;
                                if (legendary[material] > 250)
                                {
                                    legendary[material] -= 250;
                                    win = material;

                                }

                            }
                            else
                            {
                                legendary[material] += value;
                                count += 2;
                            }
                        }
                        else
                        {
                            if (!junk.ContainsKey(material))
                            {
                                junk.Add(material, value);
                                count += 2;
                            }
                            else
                            {
                                junk[material] += value;
                                count += 2;
                            }
                        }
                    }
                }
                

                if (stopProgram == false)
                {

                    input = Console.ReadLine()
                  .ToLower()
                  .Split()
                  .ToList();
                }
            }

            foreach (var item in legendary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        //static string Obt(string win)
        //{
        //    if (win == "motes")
        //    {
        //        return "Dragonwrath";
        //    }
        //    else if (win == "fragments")
        //    {
        //        return "Valanyr";

        //    }
        //    else if (win == "shards")
        //    {
        //        return "Shadowmourne";
        //    }
        }
        
    }

// 3 Motes 5 stones 5 Shards 6 leathers 255 fragments 7 Shards
// 6 leathers 255 fragments 7 Shards
