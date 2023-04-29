using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Classes
{
    public abstract class Product
    {
        public string  Name { get; set; }
        public static List<Item> Ingredients;
        public bool IsPopular;


    }
}
