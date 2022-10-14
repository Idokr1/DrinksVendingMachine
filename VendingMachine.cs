using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine
{
    public class VendingMachine
    {
        private Beverages[] _beveragesArr;
        private int _numOfBeverages;
        private const int _machineMaxCapability = 20;
        private static int _disposableCups = 50;
        private static int _milkInMiliLiters = 3000;
        private static int _sugarInGrams = 800;
        private static int _coffeeBeans = 700;
        private static int _teaLeaves = 20;
        private static int _cocoaPowderInGrams = 300;

        public VendingMachine(int size = _machineMaxCapability)
        {
            _beveragesArr = new Beverages[size];
            _numOfBeverages = 0;
        }
        public int NumOfBeverages { get { return _numOfBeverages; } }
        public static int SugarInGrams { get { return _sugarInGrams; } }
        public static int DisposableCups { get { return _disposableCups; } }
        public static int MilkInMiliLiters { get { return _milkInMiliLiters; } }
        public static int CoffeeBeans { get { return _coffeeBeans; } }
        public static int TeaLeaves { get { return _teaLeaves; } }
        public static int CocoaPowderInGrams { get { return _cocoaPowderInGrams; } }


        public bool AddBeverage(Beverages b1)
        {
            if (_numOfBeverages >= _beveragesArr.Length)
                throw new TooManyBeveragesException(_beveragesArr.Length);
            _beveragesArr[_numOfBeverages++] = b1;
            return true;
        }
        public void SelectDrink()
        {
            Console.WriteLine(ToString()); 
            Console.WriteLine("Please selcet a drink by entering his number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= _numOfBeverages)
                throw new ArgumentException();
            UseBeverageIngredients(_beveragesArr[num]);
            Console.WriteLine(_beveragesArr[num].Prepare());            
        }
        public void Restock()
        {
         if(_disposableCups < 25)
            _disposableCups += 25;
         if(_milkInMiliLiters < 1500)
            _milkInMiliLiters += 1500;
         if(_sugarInGrams < 400)
            _sugarInGrams += 400;
         if(_coffeeBeans < 350)
            _coffeeBeans += 350;
         if(_teaLeaves < 10)
            _teaLeaves += 10;
         if(_cocoaPowderInGrams < 150)
            _cocoaPowderInGrams += 150;
         
         string restock = $"\nThe amounts after the restock:\nDisposable cups: {_disposableCups}\nMilk in miliLiters: {_milkInMiliLiters}\nSugar in grams: {_sugarInGrams}\n" +
                $"Coffee beans: {_coffeeBeans}\nTea leaves: {_teaLeaves}\nCocoa powder in grams: {_cocoaPowderInGrams}";
         Console.WriteLine(restock);
        }
        public void UseBeverageIngredients(Beverages b1)
        {
            if (b1 is Coffee)
            {
                _disposableCups--;
                _coffeeBeans -= 70;
                _sugarInGrams -= 40;
                _milkInMiliLiters -= 150;
            }
            if (b1 is Tea)
            {
                _disposableCups--;
                _teaLeaves--;
            }
            if (b1 is HotChocolate)
            {
                _disposableCups--;
                _cocoaPowderInGrams -= 30;
                _sugarInGrams -= 40;
                _milkInMiliLiters -= 150;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("The Vending Machine Options:\n");
            for (int i = 0; i < _numOfBeverages; i++)
            {
                sb.AppendLine($"{i} - {_beveragesArr[i].ToString()}");
            }
            return sb.ToString();
        }

    }
}
