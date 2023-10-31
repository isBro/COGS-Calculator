using System.Security.Cryptography.X509Certificates;
using COGS_Calculator.Classes;
using COGS_Calculator.Model;
using COGS_Calculator.Services;
using COGS_Calculator.Views;

namespace COGS_Calculator
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }


        private void Start_Load(object sender, EventArgs e)
        {

            LoginView loginView = new LoginView();
            loginView.MdiParent = this;
            loginView.Show();
        }

        private void manageMenuClicked(object sender, EventArgs e)
        {
            if (DB_Connection.CurrentUser != null)
            {
                ManageMenuView menuView = new();
                menuView.MdiParent = this;
                menuView.Show();
            }
            else
            {
                LoginView loginView = new LoginView();
                loginView.MdiParent = this;
                loginView.Show();
            }

            
        }

        private void manageIngredientsClicked(object sender, EventArgs e)
        {

            if (DB_Connection.CurrentUser != null)
            {
                ManageIngredientsView ingredientsView = new();
                ingredientsView.MdiParent = this;
                ingredientsView.Show();
            }
            else
            {
                LoginView loginView = new LoginView();
                loginView.MdiParent = this;
                loginView.Show();
            }

           
        }

        private void manageItemsClicked(object sender, EventArgs e)
        {

            if (DB_Connection.CurrentUser != null)
            {
                ManageMenuItemView menuItemView = new();
                menuItemView.MdiParent = this;
                menuItemView.Show();
            }
            else
            {
                LoginView loginView = new LoginView();
                loginView.MdiParent = this;
                loginView.Show();
            }

        

        }

        private void newMenuClicked(object sender, EventArgs e)
        {

            if (DB_Connection.CurrentUser != null)
            {
                AddMenuView addMenu = new();
                addMenu.MdiParent = this;
                addMenu.Show();
            }
            else
            {
                LoginView loginView = new LoginView();
                loginView.MdiParent = this;
                loginView.Show();
            }
           

        }

        private void openMenuClicked(object sender, EventArgs e)
        {

            if (DB_Connection.CurrentUser != null)
            {
                ManageMenuView menuView = new();
                menuView.MdiParent = this;
                menuView.Show();
            }
            else
            {
                LoginView loginView = new LoginView();
                loginView.MdiParent = this;
                loginView.Show();
            }

           
        }

        private void StartViewActivated(object sender, EventArgs e)
        {
            if (AppSettings.FirstRun)
            {

                DB_Connection.SyncIngredients();
                DB_Connection.SyncMenuItems();
                DB_Connection.SyncRecipes();
                DB_Connection.SyncMenus();

                //MessageBox.Show($"{DB_Connection.GetMenu(2).MenuItems.Count()} :  {DB_Connection.GetMenu(2).MenuItems.ElementAt(0).Id}");






                AppSettings.FirstRun = false;
            }






        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


            
        }
    }
}