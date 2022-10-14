using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine
{
    internal class Tea : Beverages
    {        
        public Tea(string name, double price) : base(name, price)
        {
           
        }

        public override string ToString()
        {
            return base.ToString() + "Tea for $" + DrinkPrice;
        }

        public override string AddingIngredients()
        {
            if (VendingMachine.DisposableCups < 1)
                throw new LackOfResourceException("There aren't enough cups");
            if(VendingMachine.TeaLeaves < 1)
                throw new LackOfResourceException("There aren't enough tea leaves to make tea");

            return $"Pulling out a disposable cup, Adding tea leaves\n";
        }
        public override string AddingHotWater()
        {
            return "Adding hot water at 70°C\n";
        }
        public override string Stirring()
        {
            return "Stirring the Tea";
        }
    }
}
