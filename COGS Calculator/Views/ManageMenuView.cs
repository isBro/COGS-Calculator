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
using COGS_Calculator.Views;


namespace COGS_Calculator
{
    public partial class ManageMenuView : Form
    {
        public ManageMenuView()
        {
            InitializeComponent();
        }

        public static int menuId;
        public List<Menu> allMenus = new();

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ReloadData()
        {
            var AllMenuBindingList = new BindingList<Menu>(DB_Connection.All_Menus);
            var AllMenuBindingSource = new BindingSource(AllMenuBindingList, null);

            AllMenusDataGridView.DataSource = AllMenuBindingSource;
        }

        private void ManageMenuViewActivated(object sender, EventArgs e)
        {

            DB_Connection.SyncMenus();

            if (DB_Connection.All_Menus.Count == 0)
            {
                UseMenuButton.Enabled = false;
                DeleteMenuButton.Enabled = false;
            }
            else
            {
                ReloadData();
                menuId = int.Parse($"{AllMenusDataGridView.SelectedCells[0].Value}");
            }

           

            ReloadData();
        }

        private void UseMenuButton_Click(object sender, EventArgs e)
        {

            ActiveMenuView activeMenu = new(this);
            activeMenu.MdiParent = this.ParentForm;
            activeMenu.Show();

        }

        private void DeleteMenuButton_Click(object sender, EventArgs e)
        {


            ReloadData();
        }

        private void AM_DataGridView_Selected(object sender, EventArgs e)
        {

            try
            {
                menuId = int.Parse($"{AllMenusDataGridView.SelectedCells[0].Value}");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void EditMenuButton_Click(object sender, EventArgs e)
        {
            

            EditMenuForm editMenuForm = new(this);
            editMenuForm.MdiParent = this.ParentForm;
            editMenuForm.Show();
            this.Close();
        }
    }
}
