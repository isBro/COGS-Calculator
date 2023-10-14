using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using COGS_Calculator.Classes;

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

        public static List<Ingredient> All_Ingredients = new List<Ingredient>();

        public static List<Menu_Item> All_Menu_Items = new List<Menu_Item>();

        public static List<Menu> All_Menus = new List<Menu>();

        #region Ingredient Methods

        public static void InsertIngredient(string name, double quantity, string uom, double cost, string category)
        {

            try
            {
                string insertIngredient = $"INSERT INTO ingredient (Name, Quantity, UoM, Cost, Category) VALUES ('{name}', {quantity}, '{uom}', {cost}, '{category}');";
                MySqlCommand I_Ingredient = new MySqlCommand(insertIngredient, Conn);
                I_Ingredient.ExecuteNonQuery();

                Ingredient NewIngredient = new(name, quantity, uom, cost, category);

                // Exception handling here

                All_Ingredients.Add(NewIngredient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public static void DeleteIngredient(int id)
        {


        }

        public static void UpdateIngredient(int id, string name, float quantity, string uom, float cost, string category)
        {

        }

        public static bool CheckIngredient(int id, string name)
        {
            foreach (Ingredient item in All_Ingredients)
            {
                if (item.Id == id || item.Name.ToLower() == name)
                {
                    return true;

                }


               
            }

            return false;
        }

        public static void SyncIngredients()
        {

            try
            {
                string GetIngredients = "SELECT * FROM ingredient";
                MySqlCommand cmd = new(GetIngredients, Conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                string currentId = "";
                string currentName = "";
                string currentQuantity = "";
                string currentUom = "";
                string currentCost = "";
                string currentCategory = "";


                while (reader.Read())
                {
                    Ingredient newIngredient = new();
                    currentId = $"{reader[0]}";
                    currentName = $"{reader[1]}";
                    currentQuantity = $"{reader[2]}";
                    currentUom = $"{reader[3]}";
                    currentCost = $"{reader[4]}";
                    currentCategory = $"{reader[5]}";

                    newIngredient.Id = int.Parse(currentId);
                    newIngredient.Name = currentName;
                    newIngredient.Quantity = double.Parse(currentQuantity);
                    newIngredient.UoM = currentUom;
                    newIngredient.UnitCost = double.Parse(currentCost);
                    newIngredient.Category = currentCategory;

                    Console.WriteLine(newIngredient.ToString());

                    if (!CheckIngredient(newIngredient.Id, newIngredient.Name))
                    {
                        All_Ingredients.Add(newIngredient);
                        Console.WriteLine(newIngredient.ToString());
                    }




                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           



     

        }

        #endregion

        #region Menu_Item Methods
        public static void InsertMenuItem()
        {

        }

        public static void DeleteMenuItem()
        {

        }

        public static void UpdateMenuItem()
        {

        }

        public static void SyncMenuItems()
        {

        }

        #endregion

        #region Menu Methods
        public static void InsertMenu()
        {

        }

        public static void DeleteMenu()
        {

        }

        public static void UpdateMenu()
        {

        }

        public static void SyncMenus()
        {

        }

        #endregion







    }
}
