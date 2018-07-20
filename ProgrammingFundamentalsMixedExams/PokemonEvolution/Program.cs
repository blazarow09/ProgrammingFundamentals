//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace PokemonEvolution
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var input = Console.ReadLine();

//            //var pokeList = new Dictionary<List<KeyValuePair<string, int>>>();

//            while (input != "wubbalubbadubdub")
//            {
//                var tokens = input
//                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
//                .ToList();
//                var evolution = "";
//                var indexEvo = 0;

//                var pokemonName = tokens[0];
//                try
//                {
//                    evolution = tokens[1];
//                    indexEvo = int.Parse(tokens[2]);
//                }
//                catch (Exception)
//                {

//                }

//        //        if (input.Contains("->"))
//        //        {
//        //            if (!pokeList.ContainsKey(pokemonName))
//        //            {
//        //                pokeList[pokemonName] = new List<KeyValuePair<string, long>>();
//        //            }

//        //            pokeList[pokemonName].Add(new KeyValuePair<string, long>(evolution, indexEvo));
//        //        }
//        //        else
//        //        {
//        //            foreach (var poke in pokeList)
//        //            {
//        //                if (pokemonName == poke.Key)
//        //                {
//        //                    Console.WriteLine($"# {poke.Key}");
//        //                }
//        //            }
//        //        }
//        //        input = Console.ReadLine();
//        //    }
//        //}
//    }
//}
