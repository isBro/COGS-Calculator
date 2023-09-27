using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Classes
{
    public class Ingredient
    {

        public Ingredient(string name, float quantity, float uoM)
        {
            Name = name;
            Quantity = quantity;
            UoM = uoM;
        }

        public string Name { get; set; }
        public float Quantity { get; set; }

        public float UoM { get; set; }

    }
}
