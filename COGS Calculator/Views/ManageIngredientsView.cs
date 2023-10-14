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



        private void SaveIngredientButton_Click(object sender, EventArgs e)
        {
            
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
            

            var IngredientsBindingList = new BindingList<Ingredient>(DB_Connection.All_Ingredients);
            var IngredientsSource = new BindingSource(IngredientsBindingList, null);

            IngredientsDataGridView1.DataSource = IngredientsSource;

        }

        private void ManageIngredientsViewLoaded(object sender, EventArgs e)
        {
            
            Reload_Data();
        }
    }
}
