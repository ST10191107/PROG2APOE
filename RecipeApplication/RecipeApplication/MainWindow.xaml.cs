using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Collections.Generic;

namespace RecipeApplication
{
   // Recipes class
    public class Recipe
    {
        //getters and setters
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }
    }
    //Ingredients class
    public class Ingredient
    {
        //getters and setters
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
    }


    public partial class MainWindow : Window
    {
        //storage for all the recipes
        private List<Recipe> recipes;

        public MainWindow()
        {
            InitializeComponent();
            recipes = new List<Recipe>();
        }

        private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve ingredient details from the text boxes
            string ingredientName = txtIngredientName.Text;
            decimal ingredientQuantity = decimal.Parse(txtIngredientQuantity.Text);
            string ingredientUnit = txtIngredientUnit.Text;

            // Create a new Ingredient object
            Ingredient ingredient = new Ingredient
            {
                Name = ingredientName,
                Quantity = ingredientQuantity,
                Unit = ingredientUnit
            };

            // Clear the ingredient text boxes
            txtIngredientName.Text = "";
            txtIngredientQuantity.Text = "";
            txtIngredientUnit.Text = "";

            // Add the ingredient to the current recipe
            GetCurrentRecipe().Ingredients.Add(ingredient);
        }

        private void btnAddStep_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve the step description from the text box
            string stepDescription = txtStepDescription.Text;

            // Clear the step text box
            txtStepDescription.Text = "";

            // Add the step to the current recipe
            GetCurrentRecipe().Steps.Add(stepDescription);
        }

        private void btnAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve the recipe name from the text box
            string recipeName = txtRecipeName.Text;

            // Create a new Recipe object
            Recipe recipe = new Recipe
            {
                Name = recipeName
            };

            // Clear the recipe name text box
            txtRecipeName.Text = "";

            // Add the recipe to the list
            recipes.Add(recipe);

            // Update the recipes list box
            UpdateRecipesListBox();
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            // Clear all the input fields
            txtRecipeName.Text = "";
            txtIngredientName.Text = "";
            txtIngredientQuantity.Text = "";
            txtIngredientUnit.Text = "";
            txtStepDescription.Text = "";

            // Clear the current recipe's data
            GetCurrentRecipe().Ingredients.Clear();
            GetCurrentRecipe().Steps.Clear();
        }

        private void UpdateRecipesListBox()
        {
            // Clear the list box
            listBoxRecipes.Items.Clear();

            // Add recipes to the list box
            foreach (Recipe recipe in recipes)
            {
                listBoxRecipes.Items.Add(recipe.Name);
            }
        }

        private Recipe GetCurrentRecipe()
        {
            // Get the selected recipe from the list box
            int selectedIndex = listBoxRecipes.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < recipes.Count)
            {
                return recipes[selectedIndex];
            }

            return null;
        }
    }
}
