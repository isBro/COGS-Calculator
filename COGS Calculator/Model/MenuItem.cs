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

        public int Id { get; set; }
        public double TotalCost { get; set; }

        public string Notes { get; set; }

        public int Quantity;

        public Menu_Item(string name) {
            Name = name;

        }

        public Dictionary<String, double> Recipe = new Dictionary<String, double>();



        public void addIngredient(Ingredient item, double quantity, string uoM)
        {
            // need logic to avoid duplicate ingredients added. see methods below 
            if (!FindIngredient(item.Id))
            
            {
                Ingredients.Add(item);
                Recipe[item.Name] = MenuServices.ToOzConversion(quantity, uoM);

            }
           


        }

        public void UpdateIngredient(Ingredient item, double quantity, string uoM)
        {

        }


        public void RemoveIngredient(int id)
        {

        }


        public bool FindIngredient(int id)
        {
            foreach (var item in Ingredients)
            {
                if (item.Id.Equals(id))
                {
                    return true;
                }
               
            }

            return false;
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            if (FindIngredient(ingredient.Id))
            {
                foreach(var item in Ingredients)
                {
                    //fix logic here to relace 
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" = {TotalCost}";
        }
    }








       

    
}
