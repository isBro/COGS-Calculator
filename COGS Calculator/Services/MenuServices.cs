using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using COGS_Calculator.Classes;
using COGS_Calculator.Model;
using Org.BouncyCastle.Asn1.Cms;

namespace COGS_Calculator.Services
{
    public static class MenuServices
    {
       public static List<string> UoMList = new() { "oz", "lbs", "g" };
       public static List<string> CategoryList = new() { "FRUIT", "PROTEIN", "VEGETABLE", "BREAD", "DAIRY", "SAUCE", "PASTRY", "BEVERAGE" };
        public static List<Menu_Item> MenuTotals = new();
        


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
                       
                        //totalAmounts[key] = (item.Recipe[key] * ingredient.Quantity) * menu.PersonCount;
                        totalAmounts.Add(key, (item.Recipe[key] * ingredient.Quantity) * menu.PersonCount);
                        
                    }
                    else if (totalAmounts.Keys.Contains(key))
                    { 
                        double currentAmount = totalAmounts[key];

                        totalAmounts[key] = item.Recipe[key] * ingredient.Quantity * menu.PersonCount + currentAmount;
                    }
                }
            }



            return totalAmounts;
        }

    }
}
