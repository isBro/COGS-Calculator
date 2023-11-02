using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COGS_Calculator.Services;
using MySqlX.XDevAPI.Common;

namespace COGS_Calculator.Views
{
    public partial class NewIngredientView : Form
    {
        public NewIngredientView()
        {
            InitializeComponent();
        }

        private void SaveIngredientButton_Click(object sender, EventArgs e)
        {
            //need to add exception handling here

            if (string.IsNullOrWhiteSpace(IngredientNameTextBox.Text))
            {

            }

            if (string.IsNullOrWhiteSpace(QuantityTextBox.Text)){

            }

            if (string.IsNullOrWhiteSpace(CostTextBox.Text))
            {

            }

            if (!double.TryParse(CostTextBox.Text, out double Result))
            {

            }

            if (!double.TryParse(QuantityTextBox.Text, out double result))
            {

            }

            double quantity = double.Parse(QuantityTextBox.Text);
            double cost = double.Parse(CostTextBox.Text);

            DB_Connection.InsertIngredient(IngredientNameTextBox.Text, quantity, UoMComboBox.Text, cost, CategoryComboBox.Text);

            ManageIngredientsView manageIngredientsView = new ManageIngredientsView();
            manageIngredientsView.MdiParent = this.ParentForm;
            manageIngredientsView.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageIngredientsView manageIngredientsView = new ManageIngredientsView();
            manageIngredientsView.MdiParent = this.ParentForm.ParentForm;
            manageIngredientsView.Show();
            this.Close();
        }

        private void NewIngredientView_Load(object sender, EventArgs e)
        {
            Reload_Data();
        }

        private void Reload_Data()
        {
            UoMComboBox.DataSource = MenuServices.UoMList;
            UoMComboBox.SelectedIndex = 0;
            CategoryComboBox.DataSource = MenuServices.CategoryList;

        }
    }
}
