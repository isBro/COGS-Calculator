using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using COGS_Calculator.Classes;
using COGS_Calculator.Model;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Asn1.Cms;

namespace COGS_Calculator.Services
{
    public static class MenuServices
    {
       public static List<string> UoMList = new() { "oz", "qt", "gal" };
       public static List<string> CategoryList = new() { "FRUIT", "PROTEIN", "VEGETABLE", "BREAD", "DAIRY", "SAUCE", "PASTRY", "BEVERAGE" };
        public static List<Menu_Item> MenuTotals = new();
        


        public static double ToOzConversion(double quantity, string startingUoM)
        {
            double converted_quantity = 0;


            switch (startingUoM)
            {
                case "qt":
                    converted_quantity = quantity * 32;
                    break;
                case "gal":
                    converted_quantity = quantity * 128;
                    break;
                case "oz":
                    converted_quantity = quantity;
                    break;

            }

            return converted_quantity;
        }

        public static double ToQtConversion(double quantity, string startingUoM)
        {
            double converted_quantity = 0;

            switch (startingUoM)
            {
                case "gal":
                    converted_quantity = quantity / 128;
                    break;

                case "oz":
                    converted_quantity = quantity / 32;
                    break;

                case "qt":
                    converted_quantity = quantity;
                    break;

            }

            return converted_quantity;

        }





        public static Dictionary<string, double> GetIngredientQuantities(Menu menu)
        {
            Dictionary<string, double> totalAmounts = new();

            foreach (Menu_Item item in menu.MenuItems)
            {
                foreach (var key in item.Recipe.Keys)

                {
                    Ingredient ingredient = DB_Connection.GetIngredient(key);



                    if (!totalAmounts.Keys.Contains(key))
                    {

                        double tempAmount = (item.Recipe[key] * ingredient.Quantity) * menu.PersonCount;

                        totalAmounts.Add(key, ToQtConversion(tempAmount, "oz"));


                    }
                    else if (totalAmounts.Keys.Contains(key))
                    {
                        double currentAmount = totalAmounts[key];
                        double tempAmount = item.Recipe[key] * ingredient.Quantity * menu.PersonCount + currentAmount;

                        totalAmounts[key] = ToQtConversion(tempAmount, "oz");
                    }
                }
            }

            foreach (var key in totalAmounts.Keys)
            {
                

                    double tempAmount = totalAmounts[key];

                    totalAmounts[key] = tempAmount / totalAmounts.Count();

            }

            return totalAmounts;
        }


        public static double GetTotalCost(Menu menu)
        {
            double cost = 0;

            foreach(Menu_Item menu_Item in menu.MenuItems)
            {
                cost += menu_Item.TotalCost;

            }

            cost = cost * menu.PersonCount;

            return cost;
        }

    }
}
