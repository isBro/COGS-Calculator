using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COGS_Calculator.Classes;
using COGS_Calculator.Model;
using COGS_Calculator.Services;

namespace COGS_Calculator.Views
{
    public partial class EditMenuForm : Form
    {
        public EditMenuForm()
        {
            InitializeComponent();
        }

        public Menu menu = new();
        public int menuId { get; set; }

        public List<Menu_Item> allAvailableItems = new();

        public Menu_Item selectedMenuItem = new();

        public Menu_Item currentMenuItem = new();

        public EditMenuForm(Form callingForm)
        {
            InitializeComponent();

            ManageMenuView manageMenuView = callingForm as ManageMenuView;
            menuId = ManageMenuView.menuId;
            menu = DB_Connection.GetMenu(menuId);

        }

        private void Save_Menu_Button_Click(object sender, EventArgs e)
        {
            //exception handling needed


            menu.PersonCount = int.Parse($"{PersonCountTextBox.Text}");
            menu.MenuNotes = NotesTextBox.Text;


            DB_Connection.UpdateMenu(menu.Id, menu.MenuName, menu.PersonCount, menu.MenuNotes, menu.MenuItems);

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMenu_Item_Button_Click(object sender, EventArgs e)
        {
            if (allAvailableItems.Count <= 1)
            {
                AddMenu_Item_Button.Enabled = false;
                menu.MenuItems.Add(selectedMenuItem);
                Remove_Menu_Item_Button.Enabled = true;
            }
            else
            {
                menu.MenuItems.Add(selectedMenuItem);
                Remove_Menu_Item_Button.Enabled = true;
            }



            ReloadData();
        }

        private void Remove_Menu_Item_Button_Click(object sender, EventArgs e)
        {
            if (menu.MenuItems.Count <= 1)
            {
                menu.MenuItems.Remove(currentMenuItem);
                Remove_Menu_Item_Button.Enabled = false;
            }
            else
            {
                menu.MenuItems.Remove(currentMenuItem);
            }

            ReloadData();
        }

        private void EditMenuView_Activated(object sender, EventArgs e)
        {
            ReloadData();

            if (menu.MenuItems.Count < 1)
            {
                Remove_Menu_Item_Button.Enabled = false;
            }

            MenuNameTextBox.Text = menu.MenuName;
            PersonCountTextBox.Text = $"{menu.PersonCount}";
            NotesTextBox.Text = menu.MenuNotes;

        }

        private void AllMenu_ItemDataGrid_Clicked(object sender, EventArgs e)
        {
            selectedMenuItem = DB_Connection.GetMenuItem(int.Parse($"{AllMenu_ItemDataGrid.SelectedCells[0].Value}"));
        }

        private void CurrentMenu_ItemDataGrid_Clicked(object sender, EventArgs e)
        {
            currentMenuItem = DB_Connection.GetMenuItem(int.Parse($"{CurrentMenu_ItemDataGrid.SelectedCells[0].Value}"));
        }

        private void ReloadData()
        {
            allAvailableItems = DB_Connection.All_Menu_Items.Where(Menu_Item => !menu.MenuItems.Contains(Menu_Item)).ToList();

            var AllMenuItemBindingList = new BindingList<Menu_Item>(allAvailableItems);
            var AllMenuBindingSource = new BindingSource(AllMenuItemBindingList, null);

            var currentMenuItemBindingList = new BindingList<Menu_Item>(menu.MenuItems.ToList());
            var currentMenuItemBindingSource = new BindingSource(currentMenuItemBindingList, null);

            AllMenu_ItemDataGrid.DataSource = AllMenuBindingSource;
            CurrentMenu_ItemDataGrid.DataSource = currentMenuItemBindingList;
        }
    }
}
