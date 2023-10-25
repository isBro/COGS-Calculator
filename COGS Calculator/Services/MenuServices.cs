using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}
