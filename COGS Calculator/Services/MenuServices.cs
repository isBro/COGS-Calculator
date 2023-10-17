using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Services
{
    public static class MenuServices
    {
       

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




    }
}
