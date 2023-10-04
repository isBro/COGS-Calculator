using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Classes
{
    public class Menu
    {

        public Menu(string name, int personCount, string notes = "")
        {
            MenuName = name;
            MenuNotes = notes;
            PersonCount = personCount;


        }
        public string MenuName { get; set; }
        public string MenuNotes { get; set; }

        public int PersonCount { get; set; }

        public List<Menu_Item> MenuItems = new();

        public void AddMenuItem(Menu_Item menuItem)
        {
            MenuItems.Add(menuItem);
        }

        public Dictionary<Menu_Item, int> ItemsAndQuantities = new();

        public void CalculateQ(List<Menu_Item> items, int headCount) { 
        
        
        }
    }
}
