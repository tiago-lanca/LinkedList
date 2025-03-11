using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    internal interface ILinkedList<T>
    {
        /// <summary>
        /// Returning if a linkedlist has values inside.
        /// </summary>
        /// <returns>False if linkedlist is not empty. True if linkedlist is empty</returns>
        public bool IsEmpty();
        public void Remove(int value);
        public void RemoveFromStart();
        public void InsertAtStart(int value);
        public void AddLast(int value);
        public Node<T> Find(int value);

        public void ListAllNodes();
    }
}
