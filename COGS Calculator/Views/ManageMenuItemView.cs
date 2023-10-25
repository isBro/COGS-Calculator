using COGS_Calculator.Classes;
using COGS_Calculator.Services;
using COGS_Calculator.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COGS_Calculator
{
    public partial class ManageMenuItemView : Form
    {
        public ManageMenuItemView()
        {
            InitializeComponent();
        }

        public Menu_Item currentMenuItem = new();

        public Dictionary<string, double> currentRecipe = new();

        public List<Ingredient> ingredientList = new();

        public Ingredient ingredient = new();

        public double cost = 0.00;

        public static string inputIngredientName { get; set; }
        public static double inputQuantity { get; set; }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_MenuItem_Button_Click(object sender, EventArgs e)
        {

            NewMenuItemView newMenuItemView = new();
            newMenuItemView.MdiParent = this.ParentForm;
            newMenuItemView.Show();
        }

        private void MenuItem_Save_Button_Click(object sender, EventArgs e)
        {

            //exception handling needed



            DB_Connection.UpdateMenuItem(currentMenuItem.Id, Name_TextBox.Text, currentMenuItem.TotalCost, IsPopular_Button.Checked, currentRecipe);
            MessageBox.Show("Update Saved");


        }

        private void Recipe_Add_Button_Click(object sender, EventArgs e)
        {
            if (ingredient.Name != null)
            {
                currentRecipe.Add($"{ingredient.Name}", 1.0);
                cost += (ingredient.UnitCost * currentRecipe[ingredient.Name]);
                TotalCost_TextBox.Text = $"{cost}";
                currentMenuItem.TotalCost = cost;


            }

            ReloadData();

            if (ingredientList.Count == 0)
            {
                Recipe_Add_Button.Enabled = false;
            }

            else
            {
                Recipe_Add_Button.Enabled = true;
                ingredient = DB_Connection.GetIngredient(int.Parse($"{All_IngredientsView.SelectedCells[0].Value}"));

                inputIngredientName = $"{All_Recipe_IngredientsView.SelectedCells[0].Value}";
                inputQuantity = double.Parse($"{All_Recipe_IngredientsView.SelectedCells[1].Value}");
                Recipe_Remove_Button.Enabled = true;
                Edit_Quantity_Button.Enabled = true;
            }
        }

        private void Recipe_Remove_Button_Click(object sender, EventArgs e)
        {
            if (currentRecipe.Count > 1)
            {

                cost -= (ingredient.UnitCost * currentRecipe[inputIngredientName]);
                currentRecipe.Remove($"{inputIngredientName}");
                TotalCost_TextBox.Text = $"{cost}";
                currentMenuItem.TotalCost = cost;
                ReloadData();

                Recipe_Add_Button.Enabled = true;



                inputIngredientName = $"{All_Recipe_IngredientsView.SelectedCells[0].Value}";
                inputQuantity = double.Parse($"{All_Recipe_IngredientsView.SelectedCells[1].Value}");
            }

            else if (currentRecipe.Count == 1)
            {
                currentRecipe.Remove($"{inputIngredientName}");
                ReloadData();

                Recipe_Add_Button.Enabled = true;
                Recipe_Remove_Button.Enabled = false;
                Edit_Quantity_Button.Enabled = false;
            }
        }

        private void ManageMenuItemView_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        public void ReloadData()
        {

            ingredientList = DB_Connection.All_Ingredients.Where(Ingredient => !currentRecipe.ContainsKey(Ingredient.Name)).ToList();


            var AllMenuItemBindingList = new BindingList<Menu_Item>(DB_Connection.All_Menu_Items);
            var MenuItemSource = new BindingSource(AllMenuItemBindingList, null);

            var IngredientsBindingList = new BindingList<Ingredient>(ingredientList);
            var IngredientsSource = new BindingSource(IngredientsBindingList, null);

            var RecipeBindingSource = new BindingSource(currentRecipe.ToList(), null);


            All_Recipe_IngredientsView.DataSource = RecipeBindingSource;
            All_IngredientsView.DataSource = IngredientsSource;
            All_Menu_Items_View.DataSource = MenuItemSource;



        }

        private void Edit_Quantity_Button_Click(object sender, EventArgs e)
        {
            InputView inputView = new(this);
            inputView.MdiParent = this.ParentForm.ParentForm;
            inputView.Show();
        }

        private void All_Menu_Item_Row_Clicked(object sender, EventArgs e)
        {
            int TempId = int.Parse($"{All_Menu_Items_View.SelectedCells[0].Value}");

            currentMenuItem = DB_Connection.GetMenuItem(TempId);

            ID_TextBox.Text = $"{currentMenuItem.Id}";
            Name_TextBox.Text = $"{currentMenuItem.Name}";
            TotalCost_TextBox.Text = $"{currentMenuItem.TotalCost}";
            IsPopular_Button.Checked = currentMenuItem.IsPopular;

            currentRecipe = currentMenuItem.Recipe;

            ReloadData();

        }

        private void ManageMenuItemView_Activated(object sender, EventArgs e)
        {

            // exception handling needed


            ReloadData();
            ingredient = DB_Connection.GetIngredient(int.Parse($"{All_IngredientsView.SelectedCells[0].Value}"));

            currentMenuItem = DB_Connection.GetMenuItem(int.Parse($"{All_Menu_Items_View.SelectedCells[0].Value}"));
            currentRecipe = currentMenuItem.Recipe;

            ReloadData();

            ID_TextBox.Text = $"{currentMenuItem.Id}";
            Name_TextBox.Text = $"{currentMenuItem.Name}";
            TotalCost_TextBox.Text = $"{currentMenuItem.TotalCost}";
            IsPopular_Button.Checked = currentMenuItem.IsPopular;

            if (currentRecipe.Count == 0)
            {
                Recipe_Remove_Button.Enabled = false;
                Edit_Quantity_Button.Enabled = false;
            }
        }

        private void Current_Recipe_Ingredient_Row_Clicked(object sender, EventArgs e)
        {
            inputIngredientName = $"{All_Recipe_IngredientsView.SelectedCells[0].Value}";
            inputQuantity = double.Parse($"{All_Recipe_IngredientsView.SelectedCells[1].Value}");
        }

        private void All_Ingredients_Clicked(object sender, EventArgs e)
        {
            ingredient = ingredient = DB_Connection.GetIngredient(int.Parse($"{All_IngredientsView.SelectedCells[0].Value}"));
        }
    }


}

