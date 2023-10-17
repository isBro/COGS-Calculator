using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using COGS_Calculator.Classes;
using System.Xml.Linq;
using System.Diagnostics.Eventing.Reader;

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

        public static int b_check(bool b)
        {
            if (b)
            {
                return 1;
            }

            return 0;
        }

        #region Ingredient Methods

        public static void InsertIngredient(string name, double quantity, string uom, double cost, string category)
        {

            try
            {
                if (!CheckIngredient(name))
                {
                    string insertIngredient = $"INSERT INTO ingredient (Name, Quantity, UoM, Cost, Category) VALUES ('{name}', {quantity}, '{uom}', {cost}, '{category}');";
                    MySqlCommand I_Ingredient = new MySqlCommand(insertIngredient, Conn);
                    I_Ingredient.ExecuteNonQuery();

                    Ingredient NewIngredient = new(name, quantity, uom, cost, category);

                    // Exception handling here

                    All_Ingredients.Add(NewIngredient);
                }

                else
                {
                    MessageBox.Show("There is already an item with this name");
                    return;
                }

             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public static void DeleteIngredient(int id)
        {

            try
            {
                string delete_Ingredient = $"DELETE FROM ingredient WHERE id = {id}";
                MySqlCommand cmd = new(delete_Ingredient, Conn);
                cmd.ExecuteNonQuery();


                foreach (Ingredient item in All_Ingredients)
                {
                    if (item.Id == id)
                    {
                        All_Ingredients.Remove(item);
                        cmd.ExecuteNonQuery();
                    }

                }




            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            SyncIngredients();

        }

        public static void UpdateIngredient(int id, string name, double quantity, string uom, double cost, string category)
        {



            #region Temporary find item

            //String findIngredient = $"SELECT Name, Quantity, UoM, Cost, Category FROM ingredient WHERE ID = {id};";
            //MySqlCommand find_ingredient_cmd = new(findIngredient, Conn);
            //MySqlDataReader reader = find_ingredient_cmd.ExecuteReader();


            //if (reader != null)
            //{
            //    try
            //    {
            //        while (reader.Read())
            //        {



            //            if (name != $"{reader[0]}")
            //            {

            //            }

            //            if (quantity != double.Parse($"{reader[1]}"))
            //            {

            //            }

            //            if (uom != $"{reader[2]}")
            //            {

            //            }

            //            if (cost != double.Parse($"{reader[3]}"))
            //            {

            //            }

            //            if (category != $"{reader[4]}")
            //            {

            //            }
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            #endregion


            string NewName = name;
            double NewQuantity = quantity;
            string NewUoM = uom;
            double NewCost = cost;
            string NewCategory = category;

            string updateString = $"UPDATE ingredient SET Quantity = {quantity}, UoM = '{uom}', Cost = {cost}, Category = '{category}' WHERE ID = {id} ";
            MySqlCommand Update_cmd = new(updateString, Conn);



         

                foreach (Ingredient item in All_Ingredients)
                {
                    if (item.Id == id)
                    {
                        item.Quantity = NewQuantity;
                        item.UoM = NewUoM;
                        item.UnitCost = NewCost;
                        item.Category = NewCategory;
                    }
                }


                Update_cmd.ExecuteNonQuery();




            








        }

        public static bool CheckIngredient(int id, string name)
        {
            foreach (Ingredient item in All_Ingredients)
            {
                if (item.Id == id || item.Name.ToLower() == name.ToLower())
                {
                    return true;

                }


               
            }

            return false;
        }

        public static bool CheckIngredient(string name)
        {
            foreach (Ingredient item in All_Ingredients)
            {
                if (item.Name.ToLower() == name.ToLower())
                {
                    return true;

                }

                

            }

            return false;
        }

        public static Ingredient GetIngredient(int id)
        {
            try
            {
                foreach (Ingredient item in All_Ingredients)
                {
                    if (item.Id == id)
                    {
                        return item;
                    }


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
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
        public static void InsertMenuItem(string name, double totalCost, bool isPopular, Dictionary<string, double> recipe )
        {

            if (!CheckMenuItem(name))
            {
                Menu_Item newMenu_Item = new(name);
                newMenu_Item.Recipe = recipe;

                string insertMenuItem = $"INSERT INTO menu_item (Name, TotalCost, IsPopular) VALUES ('{name}', {totalCost}, {b_check(isPopular)});";

                All_Menu_Items.Add(newMenu_Item);
            }
            else
            {
                MessageBox.Show("There is already a menu item with this name.");

            }

           
        }

        public static void DeleteMenuItem()
        {

        }

        public static void UpdateMenuItem()
        {

        }

        public static void CheckMenuItem(int id, string name)
        {

        }

        public static bool CheckMenuItem(string name)
        {
            foreach (Menu_Item item in All_Menu_Items)
            {
                if (item.Name.ToLower() == name.ToLower())
                {
                    return true;

                }



            }

            return false;
        }

        public static Menu_Item GetMenuItem(int id)
        {
            foreach (Menu_Item item in All_Menu_Items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
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
