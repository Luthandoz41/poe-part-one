using System;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            recipe.GetRecipeDetails();
            recipe.DisplayRecipe();
        }
    }

    class Recipe
    {
        private string[] ingredients;
        private string[] steps;

        public void GetRecipeDetails()
        {
            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());
            ingredients = new string[ingredientCount];

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.Write($"Enter ingredient {i + 1} name: ");
                string name = Console.ReadLine();
                Console.Write($"Enter quantity for {name}: ");
                string quantity = Console.ReadLine();
                Console.Write($"Enter unit of measurement for {name}: ");
                string unit = Console.ReadLine();
                ingredients[i] = $"{quantity} {unit} of {name}";
            }

            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());
            steps = new string[stepCount];

            for (int i = 0; i < stepCount; i++)
            {
                Console.Write($"Enter step {i + 1} description: ");
                steps[i] = Console.ReadLine();
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("\nRecipe:");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine("\nSteps:");
            foreach (var step in steps)
            {
                Console.WriteLine(step);
            }
        }
    }
}