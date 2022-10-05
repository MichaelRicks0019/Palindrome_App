using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLibrary;

namespace StackLibrary
{
    class Stack : List
    {
        public Stack() : base("stack") { }

        public void Push(object dataValue)
        {
            InsertAtFront(dataValue);
        }

        public object Pop()
        {
           return RemoveFromFront();
        }
    }
}
