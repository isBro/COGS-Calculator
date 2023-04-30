using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Classes
{
    public class Menu
    {

        public List<Menu_Item> MenuItems = new();

        public void addMenuItem(Menu_Item menuItem)
        {
            MenuItems.Add(menuItem);
        }

        public Dictionary<Menu_Item, int> ItemsAndQuantities = new();

        public void CalculateQ(List<Menu_Item> items, int headCount) { 
        
        
        }

    }
}
