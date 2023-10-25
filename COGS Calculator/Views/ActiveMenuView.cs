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

        public ActiveMenuView(Form callingForm)
        {
            InitializeComponent();

            ManageMenuView manageMenuView = callingForm as ManageMenuView;

            menu = DB_Connection.GetMenu(ManageMenuView.menuId);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void IngredientViewButton_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemViewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
