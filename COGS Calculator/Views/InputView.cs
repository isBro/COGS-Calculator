using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COGS_Calculator.Views
{
    public partial class InputView : Form
    {
        public InputView()
        {
            InitializeComponent();
            
        }

        private NewMenuItemView newItemView = null;
        private ManageMenuItemView manageItemView = null;
        public InputView(Form callingform)
        {
            InitializeComponent();
            


            //need to make this view accessible between both views

            if (callingform is ManageMenuItemView)
            {
                manageItemView = callingform as ManageMenuItemView;
                newMenuInputBool = false;
            }
            else
            {
                newItemView = callingform as NewMenuItemView;
            }
        }


        public static bool newMenuInputBool { get; set; }
        public static string tempIngredient = "";
        public static double tempQuantity = 0;

        private void InputView_Load(object sender, EventArgs e)
        {
            if (newMenuInputBool)
            {
                Ingredient_Label.Text = NewMenuItemView.inputIngredientName;
                InputTextBox.Text = $"{NewMenuItemView.inputQuantity}";
                //newMenuInputBool = true;
            }
            else
            {
                Ingredient_Label.Text = ManageMenuItemView.inputIngredientName;
                InputTextBox.Text = $"{ManageMenuItemView.inputQuantity}";
            }
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {

            tempIngredient = Ingredient_Label.Text;
            tempQuantity = double.Parse(InputTextBox.Text);

            if (string.IsNullOrWhiteSpace(InputTextBox.Text)) {
                /// MESSAGE BOX
                return;
            }
            if (double.TryParse(InputTextBox.Text, out double result))
            {

            }

            if (newMenuInputBool)
            {
                NewMenuItemView.newRecipe[tempIngredient] = tempQuantity;
                this.newItemView.ReloadData();
            }

            else
            {
                this.manageItemView.currentRecipe[tempIngredient] = tempQuantity;
                this.manageItemView.ReloadData();
            }

            


            
            this.Close();
        }
    }
}
