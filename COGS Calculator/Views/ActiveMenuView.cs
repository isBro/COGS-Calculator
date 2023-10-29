using COGS_Calculator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COGS_Calculator.Classes;
using COGS_Calculator.Model;

namespace COGS_Calculator.Views
{
    public partial class ActiveMenuView : Form
    {
        public ActiveMenuView()
        {
            InitializeComponent();
        }

        public Menu menu = new();

        //public Dictionary<string, double> IngredientReportList = new();
        public List<Ingredient> IngredientReportList = new();

        public ActiveMenuView(Form callingForm)
        {
            InitializeComponent();

            ManageMenuView manageMenuView = callingForm as ManageMenuView;

            menu = DB_Connection.GetMenu(ManageMenuView.menuId);
            //IngredientReportList = MenuServices.GetIngredientQuantities(menu);
            IngredientReportList = MenuServices.IngredientTotalsPerMenu(menu);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngredientViewButton_Click(object sender, EventArgs e)
        {

            //BindingSource IngredientTotalsSource = new BindingSource(IngredientReportList.ToList(), null);
            //ActiveMenuGridView.DataSource = IngredientTotalsSource;

            BindingSource IngredientTotalsSource = new BindingSource(IngredientReportList, null);
            ActiveMenuGridView.DataSource = IngredientTotalsSource;

        }

        private void MenuItemViewButton_Click(object sender, EventArgs e)
        {




        }

        private void ReloadData()
        {

        }

        private void ActiveMenuView_Load(object sender, EventArgs e)
        {
            MenuNameLabel.Text = "Menu Name: " + menu.MenuName;
            PersonCountLabel.Text = $"Guest Count: {menu.PersonCount}";
            NotesLabel.Text = $"Notes: \n{menu.MenuNotes}";
        }
    }
}
