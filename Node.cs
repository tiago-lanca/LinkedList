using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class Node<T>
    {
        public int? Value;
        public Node<T>? Next;
        public Node<T>? Previous;

        public Node(int value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }


        public override string ToString()
        {
            return $"Node Value = {Value.ToString()} / Node Previous = {Previous.Value.ToString()} / " +
                $"Node Next = {Next.Value.ToString()}";
        }
    }
}
