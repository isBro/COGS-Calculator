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

        public Menu menu { get; set; }


        List<Ingredient> IngredientReportList = new();
        Dictionary<string, double> IngredientTotals = new();


        public ActiveMenuView(Form callingForm)
        {
            InitializeComponent();

            ManageMenuView manageMenuView = callingForm as ManageMenuView;

            menu = DB_Connection.GetMenu(ManageMenuView.menuId);


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.Close();
        }

        private void IngredientViewButton_Click(object sender, EventArgs e)
        {

            //List<Ingredient> newList = calculateIngredientTotals(menu);

            IngredientTotals = MenuServices.GetIngredientQuantities(menu);



            BindingSource IngredientTotalsSource = new BindingSource(IngredientTotals.ToList(), null);
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

        private void TotalCostButton_Click(object sender, EventArgs e)
        {

        }

        private List<Ingredient> calculateIngredientTotals(Menu menu)
        {

            //IngredientReportList.Clear();
            
            Ingredient ListIngredient;
            Ingredient newIngredient = new();
            Menu_Item newMenuItem = new();
            double iQuantity;

            foreach (Menu_Item menuItem in menu.MenuItems)
            {
                newMenuItem = DB_Connection.GetMenuItem(menuItem.Id);

                foreach (var key in newMenuItem.Recipe.Keys)
                {
                    ListIngredient = DB_Connection.GetIngredient(key);

                    newIngredient.Name = ListIngredient.Name;
                    newIngredient.Quantity = ListIngredient.Quantity;
                    newIngredient.UnitCost = ListIngredient.UnitCost;
                    newIngredient.UoM = ListIngredient.UoM;
                    newIngredient.Category = ListIngredient.Category;
                    newIngredient.Id = ListIngredient.Id;

                    Console.WriteLine($"{ListIngredient.Name}");
                    
                    if (IngredientReportList.Contains(newIngredient))
                    {
                        iQuantity = newIngredient.Quantity * newMenuItem.Recipe[newIngredient.Name];
                        newIngredient.Quantity += iQuantity;

                    }

                    else
                    {
                        iQuantity = newIngredient.Quantity * newMenuItem.Recipe[newIngredient.Name];
                        newIngredient.Quantity = iQuantity;
                        IngredientReportList.Add(newIngredient);
                    }
                }
            }

            return IngredientReportList;
        }
    }
}
