using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleSolution.Utilities.Exceptions
{
    public class ShopException : Exception
    {
        public ShopException()
        {

        }
        public ShopException(String message) : base(message) { }

        public ShopException(string message, Exception inner) : base (message, inner) { }
    }
}
