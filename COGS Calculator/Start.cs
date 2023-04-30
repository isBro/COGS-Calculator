using System.Security.Cryptography.X509Certificates;

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

        }

        private void manageIngredientsClicked(object sender, EventArgs e)
        {

        }

        private void manageItemsClicked(object sender, EventArgs e)
        {

        }

        private void newMenuClicked(object sender, EventArgs e)
        {
            AddMenuView addMenu = new();
            addMenu.MdiParent = this;
            addMenu.Show();

            
            
            

        }

        private void openMenuClicked(object sender, EventArgs e)
        {

        }
    }
}