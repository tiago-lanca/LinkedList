using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class LinkedList<T> : ILinkedList<T>
    {
        public Node<T>? Head;
        public Node<T>? Tail;
        public int Size;

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }
        public void AddLast(int value)
        {
            Node<T> nextNode = new Node<T>(value);
            if(Tail == null)
            {
                Head = nextNode;
                Head.Next = nextNode;
                Tail = nextNode;
                Tail.Previous = nextNode;
            }
            else
            {
                nextNode.Previous = Tail;
                Tail.Next = nextNode;
                Tail = nextNode;
            }

            Size++;
        }

        public Node<T> Find(int value)
        {
            var node = Head;

            if (Size > 0) {

                int count = 0;

                do
                {
                    if (node is null) break;

                    if (node.Value == value)
                    {
                        return node;
                    }

                    node = node.Next;
                    count++;

                } 
                while (count != Size);
            }

            return null;
        }

        public void InsertAtStart(int value)
        {
            var newNode = new Node<T>(value);
            var headNode = Head;

            if(Head != null)
            {                
                Head = newNode;
                Head.Next = headNode;
            }
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void ListAllNodes()
        {
            var node = Head;

            if (node != null)
                Console.Write("( ");

            while(node != null)
            {
                if (node != Tail)
                    Console.Write($"{node.Value}, ");
                else
                    Console.Write($"{node.Value} ");

                node = node.Next;
            }

            Console.WriteLine(")");
             
        }

        public void Remove(int value)
        {
            var nodeToRemove = Find(value);

            if (nodeToRemove != null)
            {
                if (nodeToRemove.Previous != null)                
                    nodeToRemove.Previous.Next = nodeToRemove.Next;

                if(nodeToRemove.Next != null)
                    nodeToRemove.Next.Previous = nodeToRemove.Previous;
            }
        }

        public void RemoveFromStart()
        {
            Node<T>? headNext = Head.Next;
            
            if(headNext != null)
            {
                Head.Next = headNext.Next;
                Head = headNext;
                Head.Previous = null;
            }
        }

    }
}
