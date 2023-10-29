using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using COGS_Calculator.Classes;
using COGS_Calculator.Model;

namespace COGS_Calculator.Services
{
    public static class MenuServices
    {
       public static List<string> UoMList = new() { "oz", "lbs", "g" };
       public static List<string> CategoryList = new() { "FRUIT", "PROTEIN", "VEGETABLE", "BREAD", "DAIRY", "SAUCE", "PASTRY", "BEVERAGE" };




        public static double ToOzConversion(double quantity, string startingUoM)
        {
            double converted_quantity = 0;


            switch (startingUoM)
            {
                case "lbs":
                    converted_quantity = quantity * 16;
                    break;
                case "g":
                    converted_quantity = quantity / 28.35;
                    break;
                case "oz":
                    converted_quantity = quantity;
                    break;

            }

            return converted_quantity;
        }



        // need method to run quantity totals - i.e. - FOR TOTAL QUANTITIES ingredient quantity @ UoM * menu_Item.Recipe[ingredient.Name] * Menu.PersonCount
        // public static method with a dictionary return type. takes a menu for input?

        public static List<Ingredient> IngredientTotalsPerMenu(Menu menu)
        {
            List<Ingredient> IngredientReportList = new();
            Ingredient listIngredient = new();

            foreach(Menu_Item menuItem in menu.MenuItems)
            {
                foreach (var key in menuItem.Recipe.Keys)
                {
                    listIngredient = DB_Connection.GetIngredient(key);
                 
                    double startingQ = listIngredient.Quantity;
                    if (!IngredientReportList.Contains(listIngredient))
                    {
                        listIngredient.Quantity = (menuItem.Recipe[key] * listIngredient.Quantity) * menu.PersonCount;
                        IngredientReportList.Add(listIngredient);
                    }
                    else
                    {
                        /////?????
                        ///

                        listIngredient.Quantity += (menuItem.Recipe[key] * listIngredient.Quantity) * menu.PersonCount;
                    }

                    

                }

            }

            return IngredientReportList;
        }

        public static Dictionary<string, double> GetIngredientQuantities(Menu menu)
        {
            Dictionary<string, double> totalAmounts = new();

            foreach(Menu_Item item in menu.MenuItems)
            {
                foreach(var key in item.Recipe.Keys) 
                
                { 
                    Ingredient ingredient = DB_Connection.GetIngredient(key);


                    if (!totalAmounts.Keys.Contains(key))
                    {
                        totalAmounts[key] = (item.Recipe[key] * ingredient.Quantity) * menu.PersonCount;
                    }
                    else
                    {
                        totalAmounts[key] += (item.Recipe[key] * ingredient.Quantity) * menu.PersonCount;
                    }
                }
            }



            return totalAmounts;
        }

    }
}
