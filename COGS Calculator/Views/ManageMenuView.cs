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
    public partial class ManageMenuView : Form
    {
        public ManageMenuView()
        {
            InitializeComponent();
        }

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
            ReloadData();
        }
    }
}
