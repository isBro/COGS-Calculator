using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Services
{
    public static class MenuServices
    {
       

        public static double OzConversion(double quantity, string startingUoM, string convertedUoM)
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

            }

            return converted_quantity;
        }




    }
}
