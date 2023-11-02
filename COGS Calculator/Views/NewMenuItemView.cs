using COGS_Calculator.Classes;
using COGS_Calculator.Services;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COGS_Calculator.Views
{
    public partial class NewMenuItemView : Form
    {
        public NewMenuItemView()
        {
            InitializeComponent();

        }


        public Menu_Item newMenuItem = new();
        public static Dictionary<string, double> newRecipe = new();
        public Ingredient ingredient = new();
        List<Ingredient> ingredientList = new();
        public double cost = 0.00;


        public static string inputIngredientName { get; set; }
        public static double inputQuantity { get; set; }
        public static bool inputBool { get; set; }


        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Save_Button_Click(object sender, EventArgs e)
        {
            //add exception handling here 

            if (string.IsNullOrWhiteSpace(Name_TextBox.Text))
            {

            }

            if (string.IsNullOrWhiteSpace(TotalCost_TextBox.Text)){

            }

            if (!double.TryParse(TotalCost_TextBox.Text, out double Result))
            {

            }


            newMenuItem.Name = Name_TextBox.Text;
            newMenuItem.TotalCost = double.Parse(TotalCost_TextBox.Text);
            newMenuItem.IsPopular = IsPopular_Button.Checked;
            newMenuItem.Recipe = newRecipe;


            try
            {
                DB_Connection.InsertMenuItem(newMenuItem.Name, newMenuItem.TotalCost, newMenuItem.IsPopular, newRecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void Recipe_Add_Button_Click(object sender, EventArgs e)
        {

            // needs Exception handling 


            if (ingredient.Name != null)
            {
                newRecipe.Add($"{ingredient.Name}", 1.0);
                cost += (ingredient.UnitCost * newRecipe[ingredient.Name]);
                TotalCost_TextBox.Text = $"{cost}";


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
            if (newRecipe.Count > 1)
            {

                cost -= (ingredient.UnitCost * newRecipe[inputIngredientName]);
                newRecipe.Remove($"{inputIngredientName}");
                TotalCost_TextBox.Text = $"{cost}";
                ReloadData();

                Recipe_Add_Button.Enabled = true;

                

                inputIngredientName = $"{All_Recipe_IngredientsView.SelectedCells[0].Value}";
                inputQuantity = double.Parse($"{All_Recipe_IngredientsView.SelectedCells[1].Value}");
            }

            else if (newRecipe.Count == 1)
            {
                newRecipe.Remove($"{inputIngredientName}");
                ReloadData();

                Recipe_Add_Button.Enabled = true;
                Recipe_Remove_Button.Enabled = false;
                Edit_Quantity_Button.Enabled = false;
            }

        }

        public void ReloadData()
        {

            
            ingredientList = DB_Connection.All_Ingredients.Where(Ingredient => !newRecipe.ContainsKey(Ingredient.Name)).ToList();

            var IngredientsBindingList = new BindingList<Ingredient>(ingredientList);
            var IngredientsSource = new BindingSource(IngredientsBindingList, null);

            var RecipeBindingSource = new BindingSource(newRecipe.ToList(), null);


            All_Recipe_IngredientsView.DataSource = RecipeBindingSource;
            All_IngredientsView.DataSource = IngredientsSource;



        }

        private void Edit_Quantity_Button_Click(object sender, EventArgs e)
        {
            InputView inputView = new(this);
            inputView.MdiParent = this.ParentForm.ParentForm;
            inputBool = true;
            inputView.Show();

        }

        private void All_Ingredients_Row_Clicked(object sender, EventArgs e)
        {
            ingredient = DB_Connection.GetIngredient(int.Parse($"{All_IngredientsView.SelectedCells[0].Value}"));
        }

        private void Current_Ingredient_Row_Clicked(object sender, EventArgs e)
        {
            inputIngredientName = $"{All_Recipe_IngredientsView.SelectedCells[0].Value}";
            inputQuantity = double.Parse($"{All_Recipe_IngredientsView.SelectedCells[1].Value}");
        }

        private void New_Menu_ItemView_Activated(object sender, EventArgs e)
        {
            //exception handling 

            ReloadData();
            if (DB_Connection.All_Ingredients.Count >=1)
            {
                ingredient = DB_Connection.GetIngredient(int.Parse($"{All_IngredientsView.SelectedCells[0].Value}"));
            }
            

            if (newRecipe.Count == 0)
            {
                Recipe_Remove_Button.Enabled = false;
                Edit_Quantity_Button.Enabled = false;
            }

           

        }

        private void NewMenuItemView_Visibility_Changed(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
