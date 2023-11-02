using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COGS_Calculator.Services;

namespace COGS_Calculator.Classes
{
    public class Menu_Item : Product
    {

        public Menu_Item() { }

        public int Id { get; set; }
        public double TotalCost { get; set; }

        public Menu_Item(string name) {
            Name = name;

        }

        public Dictionary<String, double> Recipe = new Dictionary<String, double>();

        public override string ToString()
        {
            return base.ToString() + $" = {TotalCost}";
        }
    }








       

    
}
