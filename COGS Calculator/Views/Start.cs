using System.Security.Cryptography.X509Certificates;
using COGS_Calculator.Classes;
using COGS_Calculator.Model;
using COGS_Calculator.Services;

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


        }

        private void manageMenuClicked(object sender, EventArgs e)
        {
            ManageMenuView menuView = new();
            menuView.MdiParent = this;
            menuView.Show();
        }

        private void manageIngredientsClicked(object sender, EventArgs e)
        {
            
            ManageIngredientsView ingredientsView = new();
            ingredientsView.MdiParent = this;
            ingredientsView.Show();
        }

        private void manageItemsClicked(object sender, EventArgs e)
        {

            ManageMenuItemView menuItemView = new();
            menuItemView.MdiParent = this;
            menuItemView.Show();

        }

        private void newMenuClicked(object sender, EventArgs e)
        {
            AddMenuView addMenu = new();
            addMenu.MdiParent = this;
            addMenu.Show();

        }

        private void openMenuClicked(object sender, EventArgs e)
        {
          
            ManageMenuView menuView = new();
            menuView.MdiParent = this;
            menuView.Show();
        }

        private void StartViewActivated(object sender, EventArgs e)
        {
            if (AppSettings.FirstRun)
            {

                DB_Connection.SyncIngredients();
                DB_Connection.SyncMenuItems();
                DB_Connection.SyncRecipes();
                DB_Connection.SyncMenus();
           

                

                AppSettings.FirstRun = false;
            }


          



        }
    }
}