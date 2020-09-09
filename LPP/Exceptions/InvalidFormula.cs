using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Exceptions
{
    public class InvalidFormula : Exception
    {
        public InvalidFormula(string message) : base(message)
        {

        }
    }
}
