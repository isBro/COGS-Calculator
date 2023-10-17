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

            double quantity = double.Parse(QuantityTextBox.Text);
            double cost = double.Parse(CostTextBox.Text);

            DB_Connection.InsertIngredient(IngredientNameTextBox.Text, quantity, UoMTextBox.Text, cost, CategoryTextBox.Text);
            
            ManageIngredientsView manageIngredientsView = new ManageIngredientsView();
            manageIngredientsView.MdiParent = this.ParentForm.ParentForm;
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
    }
}
