using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine
{
    public abstract class Beverages
    {
        private string _drinkName;
        private double _drinkPrice;

        public Beverages(string name, double price)
        {
            _drinkName = name;
            _drinkPrice = price;
        }
        public string DrinkName { get { return _drinkName; } set { _drinkName = value; } }
        public double DrinkPrice { get { return _drinkPrice; } set { _drinkPrice = value; } }
        public override string ToString()
        {
            return "Beverage: ";
        }
        public override bool Equals(object obj)
        {
            if (!(this.GetType() == obj.GetType()))
                return false;
            Beverages temp = (Beverages)obj;

            if (this._drinkName == temp._drinkName)
                return true;
            return false;
        }

        public abstract string AddingIngredients();
        public abstract string AddingHotWater();
        public abstract string Stirring();
        public string Prepare()
        {
            string prepare = AddingIngredients() + AddingHotWater() + Stirring();
            return prepare;
        }
    }
}
