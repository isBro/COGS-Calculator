using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Classes
{
    public class Menu_Item : Product 
    {
        public float TotalCost { get; set; }
        public float CalculateMenuItemCost() {

            return TotalCost;
        
        
        }
        public Menu_Item(string name) {
            Name = name;
            
        
        }

        


        public void addIngredients(Ingredient item)
        {
            if (item != null) { 
            Menu_Item.Ingredients.Add(item);
                TotalCost += item.UnitCost;
            
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" = {TotalCost}";
        }

    }
}
