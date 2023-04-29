using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Classes
{
    internal class Menu
    {

        public List<Menu_Item> Items;

        public void addMenuItem(Menu_Item item)
        {
            Items.Add(item);
        }

        public Dictionary<Menu_Item, int> Quantities;

        public void CalculateQ(List<Menu_Item> items, int headCount) { 
        
        
        }

    }
}
