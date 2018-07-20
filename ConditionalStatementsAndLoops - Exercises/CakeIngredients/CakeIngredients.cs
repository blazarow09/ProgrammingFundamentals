using System;

namespace CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 1; i <= 20; i++)
            {
                string ingredient = Console.ReadLine();

                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    counter++;
                }
                else if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    return;
                }

                if (i == 20)
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    return;
                }
              
            }
        }
    }
}
