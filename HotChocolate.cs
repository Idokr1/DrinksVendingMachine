using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine
{
    internal class HotChocolate : Beverages
    {        
        public HotChocolate(string name, double price) : base(name, price)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "Hot Chocolate for $" + DrinkPrice;
        }

        public override string AddingIngredients()
        {
            if (VendingMachine.DisposableCups < 1)
                throw new LackOfResourceException("There aren't enough cups");
            if (VendingMachine.CocoaPowderInGrams < 30)
                throw new LackOfResourceException("There isn't enough cocoa powder to make hot choclate");
            if (VendingMachine.SugarInGrams < 40)
                throw new LackOfResourceException("There isn't enough sugar");
            if (VendingMachine.MilkInMiliLiters < 150)
                throw new LackOfResourceException("There isn't enough milk");

            return "Pulling out a disposable cup, Adding cocoa powder, Adding sugar\n";
        }
        public override string AddingHotWater()
        {
            return "Adding hot water at 58°C and milk\n";
        }
        public override string Stirring()
        {
            return "Stirring the Hot Chocolate";
        }
    }
}
