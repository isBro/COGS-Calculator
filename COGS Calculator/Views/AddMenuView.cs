using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public List<Menu_Item> allAvailableItems = new List<Menu_Item>();
        public Menu_Item selectedMenuItem = new();
        public Menu_Item currentMenuItem = new();

        private void Save_Menu_Button_Click(object sender, EventArgs e)
        {
            DB_Connection.InsertMenu(MenuNameTextBox.Text, int.Parse($"{PersonCountTextBox.Text}"), NotesTextBox.Text, newMenu.MenuItems);
            this.Close();
            
        }

        private void AddMenu_Item_Button_Click(object sender, EventArgs e)
        {
            if (allAvailableItems.Count <= 1)
            {
                AddMenu_Item_Button.Enabled = false;
                newMenu.MenuItems.Add(selectedMenuItem);
                Remove_Menu_Item_Button.Enabled = true;
            }
            else
            {
                newMenu.MenuItems.Add(selectedMenuItem);
                Remove_Menu_Item_Button.Enabled = true;
            }



            ReloadData();
        }

        private void Remove_Menu_Item_Button_Click(object sender, EventArgs e)
        {

            if (newMenu.MenuItems.Count <= 1)
            {
                newMenu.MenuItems.Remove(currentMenuItem);
                Remove_Menu_Item_Button.Enabled = false;
            }
            else
            {
                newMenu.MenuItems.Remove(currentMenuItem);
            }

            ReloadData();
        }

        private void AddMenuView_Activated(object sender, EventArgs e)
        {
            ReloadData();

            if (newMenu.MenuItems.Count < 1)
            {
                Remove_Menu_Item_Button.Enabled = false;
            }
        }

        private void ReloadData()
        {
            allAvailableItems = DB_Connection.All_Menu_Items.Where(Menu_Item => !newMenu.MenuItems.Contains(Menu_Item)).ToList();

            var AllMenuItemBindingList = new BindingList<Menu_Item>(allAvailableItems);
            var AllMenuBindingSource = new BindingSource(AllMenuItemBindingList, null);

            var currentMenuItemBindingList = new BindingList<Menu_Item>(newMenu.MenuItems.ToList());
            var currentMenuItemBindingSource = new BindingSource(currentMenuItemBindingList, null);

            AllMenu_ItemDataGrid.DataSource = AllMenuBindingSource;
            CurrentMenu_ItemDataGrid.DataSource = currentMenuItemBindingList;



        }

        private void AllMenu_ItemDataGrid_Clicked(object sender, EventArgs e)
        {
            selectedMenuItem = DB_Connection.GetMenuItem(int.Parse($"{AllMenu_ItemDataGrid.SelectedCells[0].Value}"));

        }

        private void CurrentMenu_ItemDataGrid_Clicked(object sender, EventArgs e)
        {
            currentMenuItem = DB_Connection.GetMenuItem(int.Parse($"{CurrentMenu_ItemDataGrid.SelectedCells[0].Value}"));

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
