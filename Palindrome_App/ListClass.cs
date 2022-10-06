using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyListExceptionNMSP;

namespace ListLibrary
{
    class ListNode
    {
        public object Data { get; private set; }
        public ListNode Next { get; set; }

        public ListNode(object datavalue) : this(datavalue, null) { }

        public ListNode(object datavalue, ListNode nextNode)
        {
            Data = datavalue;
            Next = nextNode;
        }
    }

    public class List
    {
        private ListNode firstNode;
        private ListNode lastNode;
        public string name;

        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        public List()
        {
            name = "List";
        }


        public bool IsEmpty()
        {
            return firstNode == null;
        }

        public void InsertAtFront(object insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                firstNode = new ListNode(insertItem, firstNode);
            }
        }

        public void InsertAtBack(object insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode(insertItem);
            }
        }

        public object RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            object removeItem = firstNode.Data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem;
        }

        public object RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            object removeItem = lastNode.Data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNode current = firstNode;

                while (current.Next != lastNode)
                {
                    current = current.Next;
                }

                lastNode = current;
                current.Next = null;
            }

            return removeItem;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The List {name} contains:");

                ListNode current = firstNode;

                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }

        public string DisplayReturn()
        {
            if (IsEmpty())
            {
               return $"Empty {name}";
            }
            else
            {
                ListNode current = firstNode;
                string temp = "";

                while (current != null)
                {   
                    
                    temp += current.Data;
                    current = current.Next;
                }

                return temp;
            }
        }
    }


}
