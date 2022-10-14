using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine
{
    internal class Coffee : Beverages
    {
        public Coffee(string name, double price) : base(name, price)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "Coffee for $" + DrinkPrice;
        }

        public override string AddingIngredients()
        {
            if (VendingMachine.DisposableCups < 1)
                throw new LackOfResourceException("There aren't enough cups");
            if (VendingMachine.CoffeeBeans < 70)
                throw new LackOfResourceException("There aren't enough coffee beans to make coffee");
            if (VendingMachine.SugarInGrams < 40)
                throw new LackOfResourceException("There isn't enough sugar");
            if (VendingMachine.MilkInMiliLiters < 150)
                throw new LackOfResourceException("There isn't enough milk");

            return $"Pulling out a disposable cup, Adding coffee beans, Adding sugar\n";
        }
        public override string AddingHotWater()
        {
            return "Adding hot water at 65°C, Adding milk\n";
        }
        public override string Stirring()
        {
            return "Stirring the Coffee";
        }
    }
}
