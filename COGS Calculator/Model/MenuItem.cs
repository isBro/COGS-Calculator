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
        public double TotalCost { get; set; }

        public string Notes { get; set; }

        public int Quantity;

        public Menu_Item(string name) {
            Name = name;
            Quantity = 1;

        }

       
        public void addIngredient(Ingredient item, double quantity, string uoM)
        {
            // need logic to avoid duplicate ingredients added. see methods below 

            if (!FindIngredient(item.Id)){

                if (item != null)
                {

                    if (item.UoM == uoM)
                    {
                        item.MenuItemYield = quantity;

                        Menu_Item.Ingredients.Add(item);

                        TotalCost += (item.UnitCost * item.MenuItemYield);
                    }

                    else
                    {
                        item.MenuItemYield = MenuServices.OzConversion(quantity, uoM, item.UoM);

                        Menu_Item.Ingredients.Add(item);

                        TotalCost += (item.UnitCost * item.MenuItemYield);
                    }
                }


            }


        }


        public void RemoveIngredient(int id)
        {
            foreach (Ingredient item in Ingredients)
            {
                if (item.Id == id)
                {
                    Ingredients.Remove(item);
                    TotalCost -= (item.UnitCost * item.MenuItemYield);
                }
            }
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
