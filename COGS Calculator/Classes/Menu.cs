using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Classes
{
    public class Menu
    {

        public List<Menu_Item> Items;

        public void addMenuItem(Menu_Item item)
        {
            Items.Add(item);
        }

        public Dictionary<Menu_Item, int> ItemsAndQuantities = new Dictionary<Menu_Item, int>();

        public void CalculateQ(List<Menu_Item> items, int headCount) { 
        
        
        }

    }
}
