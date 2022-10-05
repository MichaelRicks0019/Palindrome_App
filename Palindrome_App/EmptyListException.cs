using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyListExceptionNMSP
{
    public class EmptyListException : Exception
    {
        public EmptyListException() : base("The list is empty") { }

        public EmptyListException(string name) : base($"The {name} is empty") { }

        public EmptyListException(string exception, Exception inner) : base(exception, inner) { }
    }
}
