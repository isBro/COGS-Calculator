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
            OpenMenuView openMenu = new();
            openMenu.MdiParent = this;
            openMenu.Show();
        }

        private void StartViewActivated(object sender, EventArgs e)
        {
            if (AppSettings.FirstRun)
            {
                Ingredient avocado = new Ingredient("Avocado", 3, "oz", .85, "VEGATABLE");
                Ingredient bacon = new Ingredient("Bacon", 4, "oz", .45, "PROTEIN");
                Ingredient tomato = new Ingredient("Tomato", 3, "oz", .05, "VEGETABLE");
                Ingredient mesculin = new Ingredient("Mesculin", 2, "oz", .03, "VEGETABLE");
                Ingredient multigrain = new Ingredient("Multigrain", 5, "oz", .60, "BREAD");

                Menu_Item blat = new Menu_Item("BLAT Sandwich");
                blat.addIngredient(avocado, 1, avocado.UoM);
                blat.addIngredient(bacon, 1, bacon.UoM);
                blat.addIngredient(tomato, 1, tomato.UoM);
                blat.addIngredient(mesculin, 1, mesculin.UoM);
                blat.addIngredient(multigrain, 1, multigrain.UoM);


                Menu test_Menu = new Menu("Test Menu", 20, "Testing menus and features");
                test_Menu.AddMenuItem(blat);

                AppSettings.FirstRun = false;
            }


          



        }
    }
}