using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace COGS_Calculator.Services
{
    public static class DB_Connection
    {

        public static MySqlConnection Conn { get; set; }

        public static void StartConnection()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["local_db"].ConnectionString;
                Conn = new MySqlConnection(constr);
                Conn.Open();
                //MessageBox.Show("SUCCESS");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CloseConnection()
        {

            if (Conn != null)
            {
                Conn.Close();

            }

        }

        #region Ingredient Methods

        public static void InsertIngredient()
        {

        }

        #endregion

        #region Menu_Item Methods
        public static void InsertMenuItem()
        {

        }

        #endregion

        #region Menu Methods
        public static void InsertMenu()
        {

        }

        #endregion







    }
}
