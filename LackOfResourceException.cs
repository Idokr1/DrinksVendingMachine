using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine
{
    public class LackOfResourceException : Exception
    {
        public int MinAmount { get; private set; }
        public LackOfResourceException() { }
        public LackOfResourceException(string message) : base(message) { }
        public LackOfResourceException(string message, Exception inner) : base(message, inner) { }

        public LackOfResourceException(int num) { MinAmount = num; }
        public LackOfResourceException(string message, int num) : base(message) { MinAmount = num; }


    }
}
