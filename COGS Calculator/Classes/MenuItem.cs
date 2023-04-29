using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Classes
{
    public class Menu_Item : Product 
    {
        public Menu_Item(string name) {
            Name = name;
        
        }


        public void addIngredients(Item item)
        {
            if (item != null) { 
            Menu_Item.Ingredients.Add(item);
            
            }
        }
        
    }
}
