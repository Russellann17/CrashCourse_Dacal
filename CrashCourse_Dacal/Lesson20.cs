using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    class Lesson20
    {
        public static void L20_Recipe()
        {
            while (true)
            {
                Console.WriteLine("\n\"RECIPE MANAGEMENT SYSTEM\"" +
                    "\n[1] Add Recipe" +
                    "\n[2] Display Recipe" +
                    "\n[3] Search Recipe" +
                    "\n[0] Exit ");
                Console.Write("Choose an option:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RecipeManager.AddRecipe();
                        break;
                    case 2:
                        RecipeManager.DisplayRecipes();
                        break;
                    case 3:
                        Console.WriteLine("Enter a recipe name to search:");
                        string searchName = Console.ReadLine();
                        RecipeManager.SearchRecipe(searchName);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }


        }

        class Recipe
        {
            public string name { get; set; }
            public List<string> ingredients { get; set; }
            public string instructions { get; set; }

            public Recipe(string name, List<string> ingredients, string instructions)
            {
                this.name = name;
                this.ingredients = ingredients;
                this.instructions = instructions;
            }
        }
        class RecipeManager
        {
            static List<Recipe> recipes = new List<Recipe>();

            public static void AddRecipe()
            {
                while (true)
                {
                    Console.WriteLine("Enter recipe name (or type 'exit' to quit):");
                    string recipeName = Console.ReadLine();
                    if (recipeName.ToLower() == "exit") break;

                    Console.WriteLine("Enter ingredients (comma separated):");
                    string ingredientsInput = Console.ReadLine();
                    List<string> ingredients = new List<string>(ingredientsInput.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries));

                    Console.WriteLine("Enter instructions:");
                    string instructions = Console.ReadLine();

                    recipes.Add(new Recipe(recipeName, ingredients, instructions));
                    Console.WriteLine("Recipe added!\n");
                }
            }

            public static void DisplayRecipes()
            {
                Console.WriteLine("All Recipes:");
                foreach (var recipe in recipes)
                {
                    Console.WriteLine("Recipe: " + recipe.name);
                }
            }

            public static void SearchRecipe(string name)
            {
                var recipe = recipes.Find(r => r.name.Equals(name, StringComparison.OrdinalIgnoreCase));

                if (recipe != null)
                {
                    Console.WriteLine("Found recipe: " + recipe.name + "\nIngredients: " + string.Join(", ", recipe.ingredients));
                    Console.WriteLine("Instructions: " + recipe.instructions);
                }
                else
                {
                    Console.WriteLine("Recipe not found.");
                }
            }
        }
    }
}
