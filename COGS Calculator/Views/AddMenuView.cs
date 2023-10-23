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
using COGS_Calculator.Services;

namespace COGS_Calculator
{
    public partial class AddMenuView : Form
    {
        public AddMenuView()
        {
            InitializeComponent();
        }

        public Menu newMenu = new();


        private void Save_Menu_Button_Click(object sender, EventArgs e)
        {

        }

        private void AddMenu_Item_Button_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void Remove_Menu_Item_Button_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void AddMenuView_Activated(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void ReloadData()
        {

        }
    }
}
