using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COGS_Calculator.Model;
using COGS_Calculator.Classes;
using COGS_Calculator.Services;
using System.Globalization;
using System.IO;

namespace COGS_Calculator.Views
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DB_Connection.Validate_User(userNameTextBox.Text, passwordTextBox.Text))
                {
                    this.Close();




                }

                else
                {


                    string message = "Invalid UserName and/or Password. Please try again";

                    switch (System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName)
                    {

                        case "es":
                            message = "Usuario o contrasea invalido. Intentalo de nuevo.";
                            break;

                        case "fr":

                            message = "Nom d'utilisateur out mot de passe invalide. Veuillez reesayer.";
                            break;


                    }
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }


            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}

