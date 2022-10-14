using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine
{
    public class TooManyBeveragesException : Exception
    {
        public int MaxBeverages { get; private set; }
        public TooManyBeveragesException() { }
        public TooManyBeveragesException(string message) : base(message) { }
        public TooManyBeveragesException(string message, Exception inner) : base(message, inner) { }

        public TooManyBeveragesException(int num) { MaxBeverages = num; }
        public TooManyBeveragesException(string message, int num) : base(message) { MaxBeverages = num; }

    }
}
