using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Classes
{
    public class Ingredient
    {

        public Ingredient(string name, float quantity, string uoM)
        {
            Name = name;
            Quantity = quantity;
            UoM = uoM;
        }

        public string Name { get; set; }
        public float Quantity { get; set; }

        public string UoM { get; set; }

        public float UnitCost { get; set; } 

    }
}
