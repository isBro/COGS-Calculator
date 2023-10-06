using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Classes
{
    public class Ingredient
    {

        

        public Ingredient(string name, double quantity, string uoM, double unitCost, string category)
        {

            Name = name;
            Quantity = quantity;
            UoM = uoM;
            UnitCost = unitCost;
            Category = category;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }

        public double MenuItemYield { get; set; }

        public string UoM { get; set; }

        public double UnitCost { get; set; } 

        public string Category { get; set; }

    }
}
