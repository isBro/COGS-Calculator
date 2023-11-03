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
    public partial class ManageIngredientsView : Form
    {
        public ManageIngredientsView()
        {
            InitializeComponent();
        }

        public static int Ingredient_Id;
        public bool selectionChanged = false;
        public Ingredient ingredient = new Ingredient();
        public List<Ingredient> IngredientList = new();



        private void SaveIngredientButton_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrWhiteSpace(IngredientNameTextBox.Text))
                {
                    MessageBox.Show("Name cannot be blank");
                    return;
                }

                if (string.IsNullOrWhiteSpace(QuantityTextBox.Text))
                {

                    MessageBox.Show("Quantity cannot be blank");
                    return;

                }

                if (string.IsNullOrWhiteSpace(CostTextBox.Text))
                {
                    MessageBox.Show("Cost cannot be blank");
                    return;
                }

                if (!double.TryParse(CostTextBox.Text, out double Result))
                {
                    MessageBox.Show("Please enter a valid value for Cost");
                    return;
                }

                if (!double.TryParse(QuantityTextBox.Text, out double result))
                {
                    MessageBox.Show("Please enter a valid value for Quantity");
                    return;
                }


                DB_Connection.UpdateIngredient(Ingredient_Id, IngredientNameTextBox.Text, double.Parse(QuantityTextBox.Text), UoMComboBox.Text, double.Parse(CostTextBox.Text), CategoryComboBox.Text);
                MessageBox.Show("Update Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Reload_Data();
        }

        private void NewIngredientButton_Click(object sender, EventArgs e)
        {
            NewIngredientView newIngredientView = new NewIngredientView();
            newIngredientView.MdiParent = this.ParentForm;
            newIngredientView.Show();
            this.Close();


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reload_Data()
        {

            IngredientList = DB_Connection.All_Ingredients;

            DB_Connection.SyncIngredients();
            var IngredientsBindingList = new BindingList<Ingredient>(IngredientList);
            var IngredientsSource = new BindingSource(IngredientsBindingList, null);

            IngredientsDataGridView1.DataSource = IngredientsSource;

            UoMComboBox.DataSource = MenuServices.UoMList;
            UoMComboBox.SelectedIndex = 0;

            DB_Connection.SyncIngredients();


        }

        private void ManageIngredientsViewLoaded(object sender, EventArgs e)
        {
            Reload_Data();

            if (DB_Connection.All_Ingredients.Count >= 1)
            {
                Ingredient_Id = int.Parse($"{IngredientsDataGridView1.SelectedCells[0].Value}");
                ingredient = DB_Connection.GetIngredient(Ingredient_Id);

                IdTextBox.Text = Ingredient_Id.ToString();
                IngredientNameTextBox.Text = ingredient.Name;
                QuantityTextBox.Text = ingredient.Quantity.ToString();
                UoMComboBox.Text = ingredient.UoM;
                CostTextBox.Text = ingredient.UnitCost.ToString();
                CategoryComboBox.Text = ingredient.Category;
            }





        }

        private void DeleteIngredientButton_Click(object sender, EventArgs e)

        {
            foreach (Menu_Item item in DB_Connection.All_Menu_Items)
            {
                if (item.Recipe.Keys.Contains(ingredient.Name))
                {
                    MessageBox.Show("This ingredient is associated with at least one menu_item. Please remove ingredient from all menu items to delete.");
                    return;
                }
            }


            string message = "This cannot be undone, are you sure you want to delete?";
            DialogResult result = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Ingredient_Id = (int)IngredientsDataGridView1.SelectedCells[0].Value;
                DB_Connection.DeleteIngredient(Ingredient_Id);
                Reload_Data();
            }
        }

        private void Ingredient_View_Selection_Changed(object sender, EventArgs e)
        {


        }

        private void IngredientView_Row_Clicked(object sender, DataGridViewCellEventArgs e)
        {

            Ingredient_Id = int.Parse($"{IngredientsDataGridView1.SelectedCells[0].Value}");


            ingredient = DB_Connection.GetIngredient(Ingredient_Id);

            IdTextBox.Text = Ingredient_Id.ToString();
            IngredientNameTextBox.Text = ingredient.Name;
            QuantityTextBox.Text = ingredient.Quantity.ToString();
            UoMComboBox.Text = ingredient.UoM;
            CostTextBox.Text = ingredient.UnitCost.ToString();
            CategoryComboBox.Text = ingredient.Category;

        }

        private void IngredientSearchBarSelectionChanged(object sender, EventArgs e)
        {

            IngredientList = DB_Connection.All_Ingredients.Where(Ingredient => Ingredient.Name.ToLower().StartsWith(Ingredient_SearchBox.Text.ToLower())).ToList();

            var IngredientsBindingList = new BindingList<Ingredient>(IngredientList);
            var IngredientsSource = new BindingSource(IngredientsBindingList, null);

            IngredientsDataGridView1.DataSource = IngredientsSource;

            if (IngredientList.Count != 0)
            {
                Ingredient_Id = int.Parse($"{IngredientsDataGridView1.SelectedCells[0].Value}");


                ingredient = DB_Connection.GetIngredient(Ingredient_Id);

                IdTextBox.Text = Ingredient_Id.ToString();
                IngredientNameTextBox.Text = ingredient.Name;
                QuantityTextBox.Text = ingredient.Quantity.ToString();
                UoMComboBox.Text = ingredient.UoM;
                CostTextBox.Text = ingredient.UnitCost.ToString();
                CategoryComboBox.Text = ingredient.Category;

            }
        }
    }
}
