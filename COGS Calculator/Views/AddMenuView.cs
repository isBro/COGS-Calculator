﻿using System;
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
        public List<Menu_Item> allAvailableItems = new();
        public Menu_Item selectedMenuItem = new();
        public Menu_Item currentMenuItem = new();

        private void Save_Menu_Button_Click(object sender, EventArgs e)
        {
          

            if (string.IsNullOrWhiteSpace(MenuNameTextBox.Text))
            {
                MessageBox.Show("Name cannot be blank");

                return;
            }

            if (string.IsNullOrWhiteSpace(PersonCountTextBox.Text)){

                MessageBox.Show("Person Count cannot be blank");
                return;

            }

            if (string.IsNullOrWhiteSpace(NotesTextBox.Text))
            {
                MessageBox.Show("Notes cannot be blank");
                return;
            }

            if (!int.TryParse(PersonCountTextBox.Text, out int Result))
            {
                MessageBox.Show("Please use a valid value for Person Count");
                return;
            }


            newMenu.MenuName = MenuNameTextBox.Text;
            newMenu.PersonCount = int.Parse($"{PersonCountTextBox.Text}");
            newMenu.MenuNotes = NotesTextBox.Text;

            DB_Connection.InsertMenu(newMenu.MenuName, newMenu.PersonCount, newMenu.MenuNotes, newMenu.MenuItems);
            this.Close();

        }

        private void AddMenu_Item_Button_Click(object sender, EventArgs e)
        {
            if (allAvailableItems.Count <= 1)
            {
                AddMenu_Item_Button.Enabled = false;
                newMenu.MenuItems.Add(selectedMenuItem);
                Remove_Menu_Item_Button.Enabled = true;
                ReloadData();

            }
            else
            {
                newMenu.MenuItems.Add(selectedMenuItem);
                Remove_Menu_Item_Button.Enabled = true;
                ReloadData();

                selectedMenuItem = DB_Connection.GetMenuItem(int.Parse($"{AllMenu_ItemDataGrid.SelectedCells[0].Value}"));
            }

            if (newMenu.MenuItems.Count == 1)
            {
                currentMenuItem = DB_Connection.GetMenuItem(int.Parse($"{CurrentMenu_ItemDataGrid.SelectedCells[0].Value}"));
            }


        }

        private void Remove_Menu_Item_Button_Click(object sender, EventArgs e)
        {

            if (newMenu.MenuItems.Count <= 1)
            {

                newMenu.MenuItems.Remove(currentMenuItem);
                Remove_Menu_Item_Button.Enabled = false;
                ReloadData();
            }
            else
            {
                newMenu.MenuItems.Remove(currentMenuItem);
                
                ReloadData();
                currentMenuItem = DB_Connection.GetMenuItem(int.Parse($"{CurrentMenu_ItemDataGrid.SelectedCells[0].Value}"));
            }

            AddMenu_Item_Button.Enabled = true;

        }

        private void AddMenuView_Activated(object sender, EventArgs e)
        {
            ReloadData();

            if (newMenu.MenuItems.Count < 1)
            {
                Remove_Menu_Item_Button.Enabled = false;
            }

            else
            {
                selectedMenuItem = DB_Connection.GetMenuItem(int.Parse($"{AllMenu_ItemDataGrid.SelectedCells[0].Value}"));
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
