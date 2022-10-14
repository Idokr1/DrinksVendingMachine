using System;

namespace DrinksVendingMachine
{
    internal class Manager
    {
        static void Main(string[] args)
        {
            VendingMachine vm1 = new VendingMachine();
            Beverages b1 = new Coffee("Coffee", 4);
            Beverages b2 = new Tea("Tea", 3);
            Beverages b3 = new HotChocolate("HotChocolate", 6);
            int exitNum = 0;

            try
            {
                vm1.AddBeverage(b1);
                vm1.AddBeverage(b2);
                vm1.AddBeverage(b3);
            }
            catch (TooManyBeveragesException e)
            {
                Console.WriteLine("Exception caught, type: {0}", e.GetType());
                Console.WriteLine("Too many drinks are already added to the machine, current number is: {0}", e.MaxBeverages);
                Console.WriteLine(e);
            }

            while (exitNum != 9)
            {
                try
                {
                    vm1.SelectDrink();
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Exception caught, type: {0}", e.GetType());
                    Console.WriteLine("The number is invalid");
                }
                catch (LackOfResourceException e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    vm1.Restock();
                    Console.WriteLine();
                    Console.WriteLine("If you would like to exit enter '9', otherwise enter any other number: ");
                    exitNum = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("You Exited");
            Console.ReadLine();
        }
    }
}
