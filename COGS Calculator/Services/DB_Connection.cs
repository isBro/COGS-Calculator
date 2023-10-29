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
using System.Security.AccessControl;



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

        public static bool b_check(int i)
        {
            if (i == 1)
            {
                return true;
            }

            return false;
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

        public static Ingredient GetIngredient(string name)
        {
            try
            {
                foreach (Ingredient item in All_Ingredients)
                {
                    if (item.Name == name)
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

                    //Console.WriteLine(newIngredient.ToString());

                    if (!CheckIngredient(newIngredient.Id, newIngredient.Name))
                    {
                        All_Ingredients.Add(newIngredient);
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
            
            try
            {
                Menu_Item newMenu_Item = new();
                newMenu_Item.Name = name;
                newMenu_Item.TotalCost = totalCost;
                newMenu_Item.IsPopular = isPopular;
                newMenu_Item.Recipe = recipe;
                string recipeName = $"{newMenu_Item.Name.ToLower()}";
                string tempIngredient = "";
                double tempIngredientQuantity = 0.00;

                string createNewRecipe = $"CREATE TABLE {recipeName}_recipe (Ingredient VARCHAR(45), IngredientQuantity DOUBLE);";
                MySqlCommand newRecipeCmd = new(createNewRecipe, Conn);
                newRecipeCmd.ExecuteNonQuery();

               
                foreach (var key in recipe.Keys)
                {
                    tempIngredient = key;
                    tempIngredientQuantity = recipe[key];

                    string insertRecipe = $"INSERT INTO {recipeName}_recipe VALUES ('{tempIngredient}', {tempIngredientQuantity});";
                    MySqlCommand recipeCmd = new(insertRecipe, Conn);


                    recipeCmd.ExecuteNonQuery();
                }




                if (!CheckMenuItem(name))
                {

                    string insertMenuItem = $"INSERT INTO menu_item (Name, TotalCost, IsPopular) VALUES ('{name}', {totalCost}, {b_check(isPopular)});";
                    MySqlCommand insertMenuItemCmd = new(insertMenuItem, Conn);
                    insertMenuItemCmd.ExecuteNonQuery();


                    All_Menu_Items.Add(newMenu_Item);
                }
                else
                {
                    MessageBox.Show("There is already a menu item with this name.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          
            

           
        }

        public static void InsertRecipeValues(Menu_Item menuItem)
        {

        }

        public static void DeleteMenuItem(int id)
        {

            try
            {
                string deleteMenuItem = $"DELETE FROM menu_item WHERE Id = {id}";
                MySqlCommand cmd = new(deleteMenuItem, Conn);
                cmd.ExecuteNonQuery();

                foreach (Menu_Item item in All_Menu_Items)
                {
                    if (item.Id == id)
                    {
                        All_Menu_Items.Remove(item);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // add exception handling 
          

        }

        public static void UpdateMenuItem(int id, string name, double cost, bool isPopular, Dictionary<string, double> recipe)
        {
            

            foreach (Menu_Item item in All_Menu_Items)
            {
                if (item.Id == id)
                {
                    item.Name = name;
                    item.TotalCost = cost;
                    item.IsPopular = isPopular;
                    item.Recipe = recipe;
                }
            }

            string updateMenuItemString = $"UPDATE menu_item SET Name = '{name}', TotalCost = {cost}, IsPopular = {b_check(isPopular)} WHERE Id = {id};" ;
            MySqlCommand updateMenuItem = new(updateMenuItemString, Conn);
            updateMenuItem.ExecuteNonQuery();

            //delete table first

            string deleteRecipe = $"DELETE FROM {name.ToLower()}_recipe;";
            MySqlCommand deleteRecipeCmd = new(deleteRecipe, Conn);
            deleteRecipeCmd.ExecuteNonQuery();


            foreach (var key in recipe.Keys)
            {
                string updateRecipeString = $"INSERT INTO {name.ToLower()}_recipe VALUES ('{key}',{recipe[key]}) ;";
                MySqlCommand updateRecipeCmd = new(updateRecipeString, Conn);
                updateRecipeCmd.ExecuteNonQuery();

            }

          
        }

        public static bool CheckMenuItem(int id)
        {
            foreach (Menu_Item item in All_Menu_Items)
            {
                if (item.Id == id )
                {
                    return true;
                }
            }

            return false;
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
            string getMenuItems = "SELECT * FROM menu_item";
            MySqlCommand cmd = new(getMenuItems, Conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            string currentId = "";
            string currentName = "";
            string currentTotalCost = "";
            string currentIsPopular = "";

            while (reader.Read())
            {
                Menu_Item newMenuItem = new Menu_Item();
                currentId = $"{reader[0]}";
                currentName = $"{reader[1]}";
                currentTotalCost = $"{reader[2]}";
                currentIsPopular = $"{reader[3]}";

                newMenuItem.Id = int.Parse(currentId);
                newMenuItem.Name = currentName;
                newMenuItem.TotalCost = double.Parse(currentTotalCost);
                newMenuItem.IsPopular = b_check(int.Parse(currentIsPopular));

                if (!CheckMenuItem(newMenuItem.Id)){


                    All_Menu_Items.Add(newMenuItem);

                }

            }

            reader.Close();

           

            foreach (Menu_Item item in All_Menu_Items)
            {

                string recipeName = item.Name.ToLower();
                string getRecipe = $"SELECT * FROM {recipeName}_recipe;";
                MySqlCommand getRecipeCmd = new(getRecipe, Conn);


                MySqlDataReader recipeReader = getRecipeCmd.ExecuteReader();


                while (recipeReader.Read())
                {
                    item.Recipe[$"{recipeReader[0]}"] = double.Parse($"{recipeReader[1]}");

                   
                }

                recipeReader.Close();
            }

          



        }

        public static void SyncRecipes()
        {
            //foreach(Menu_Item item in All_Menu_Items)
            //{

            //    string updateRecipes = $"SELECT * FROM {item.Name.ToLower()}_recipe;";
            //    MySqlCommand updateRecipeCmd = new(updateRecipes, Conn);
            //    MySqlDataReader updateReader = updateRecipeCmd.ExecuteReader();

            //    while (updateReader.Read())
            //    {


            //        item.Recipe.Add($"{updateReader[0]}", double.Parse($"{updateReader[1]}"));
            //    }

            //    updateReader.Close();

            //}

        

            
        }

        #endregion

        #region Menu Methods
        public static void InsertMenu(string name, int personCount, string notes, List<Menu_Item> menuItems)
        {
            string insertMenu = $"INSERT INTO menu (Name, PersonCount, Notes) VALUES ('{name}', {personCount}, '{notes}');";
            MySqlCommand insertMenuCmd = new(insertMenu, Conn);
            insertMenuCmd.ExecuteNonQuery();

            string createMenuList = $"CREATE TABLE {name.ToLower()} ( MenuItemId INT, MenuItemName VARCHAR(45), TotalCost FLOAT);";
            MySqlCommand createMenuListCmd = new(createMenuList, Conn);
            createMenuListCmd.ExecuteNonQuery();

            foreach (Menu_Item item in menuItems)
            {
                string insertMenuItem = $"INSERT INTO {name.ToLower()} VALUES ({item.Id}, '{item.Name}', {item.TotalCost});";
                MySqlCommand insertMenuItemCmd = new(insertMenuItem, Conn);
                insertMenuItemCmd.ExecuteNonQuery();
            }

            Menu newMenu = new(name, personCount, notes);
            newMenu.MenuItems = menuItems;

            All_Menus.Add(newMenu);

        }

        public static void DeleteMenu(int id, string name)
        {
            string deleteMenu = $"DELETE FROM menu WHERE Id = {id};";
            MySqlCommand deleteMenuCmd = new(deleteMenu, Conn);
            deleteMenuCmd.ExecuteNonQuery();

            string dropMenuList = $"DROP TABLE {name.ToLower()};";
            MySqlCommand dropMenuListCmd = new(dropMenuList, Conn);
            dropMenuListCmd.ExecuteNonQuery();

            All_Menus.Remove(GetMenu(id));
        }

        public static void UpdateMenu(int id, string name, int personCount, string notes, List<Menu_Item> menu_Items)
        {


            string updateMenuString = $"UPDATE menu SET Name= '{name}', PersonCount= {personCount}, Notes= '{notes}' WHERE Id = {id};";
            MySqlCommand updateMenuCmd = new(updateMenuString, Conn);
            updateMenuCmd.ExecuteNonQuery();

            string dropMenuList = $"DROP TABLE {name.ToLower()};";
            MySqlCommand dropMenuListCmd = new(dropMenuList, Conn);
            dropMenuListCmd.ExecuteNonQuery();

            string createMenuList = $"CREATE TABLE {name.ToLower()} ( MenuItemId INT, MenuItemName VARCHAR(45), TotalCost FLOAT);"; 
            MySqlCommand createMenuListCmd = new(createMenuList, Conn); createMenuListCmd.ExecuteNonQuery(); 

            foreach (Menu_Item item in menu_Items) { 


                // throwing an error

                string insertMenuItem = $"INSERT INTO {name.ToLower()} VALUES ({item.Id}, '{item.Name}', {item.TotalCost});";
                MySqlCommand insertMenuItemCmd = new(insertMenuItem, Conn); 

                insertMenuItemCmd.ExecuteNonQuery();
            }


            foreach (Menu menu in All_Menus)
            {
                if (menu.Id == id)
                {
                    menu.MenuName = name;
                    menu.PersonCount = personCount;
                    menu.MenuNotes = notes;
                    menu.MenuItems = menu_Items;
                }
                
            }


        }

        public static void SyncMenus()
        {
            Menu newMenu = new();
            //Menu_Item newMenu_Item = new();

            string syncMenus = "SELECT * FROM menu;";
            MySqlCommand syncMenuCmd = new(syncMenus, Conn);
            MySqlDataReader syncMenuReader = syncMenuCmd.ExecuteReader();

            while (syncMenuReader.Read())
            {
                newMenu.Id = int.Parse($"{syncMenuReader[0]}");
                newMenu.MenuName = $"{syncMenuReader[1]}";
                newMenu.PersonCount = int.Parse($"{syncMenuReader[2]}");
                newMenu.MenuNotes = $"{syncMenuReader[3]}";

            }

            syncMenuReader.Close();

            if (!CheckMenu(newMenu.Id))
            {
                All_Menus.Add(newMenu);
               
            }

            foreach (Menu menu in All_Menus)
            {
                string syncMenuList = $"SELECT * FROM {menu.MenuName.ToLower()}";
                MySqlCommand syncMenuListCmd = new(syncMenuList, Conn);
                MySqlDataReader syncMenuListReader = syncMenuListCmd.ExecuteReader();

                while (syncMenuListReader.Read())
                {
                    Menu_Item newMenu_Item = GetMenuItem(int.Parse($"{syncMenuListReader[0]}"));

                    if (newMenu_Item != null)
                    {
                        if (!menu.MenuItems.Contains(newMenu_Item))
                        {

                            menu.MenuItems.Add(newMenu_Item);
                        }

                    }

                   
                    

                }
                syncMenuListReader.Close();

               
               


            }
            


        }


        public static Menu GetMenu(int id)
        {

            try
            {
                foreach (Menu menu in All_Menus)
                {
                    if (menu.Id == id)
                    {
                        return menu;
                    }


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public static bool CheckMenu(int id)
        {
            foreach (Menu menu in All_Menus)
            {
                if (menu.Id == id) { return true; }
                
            }

            return false;
        }
    }

    #endregion







}

