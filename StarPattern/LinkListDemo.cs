using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern
{
    internal class LinkListDemo<T>
    {
        public class Node
        {
            //Each node contains a Node which hold the reference of another node
            public Node? Next;
            //Each node holds a value of type T
            public T? Data;
        }

        //List is initially empty
        public Node? head = null;

        //Add the node at the begining of list with T as data values.
        public void AddNode(T t)
        {
            Node NewNode = new Node();
            NewNode.Next = head;
            NewNode.Data = t;
            head = NewNode;
        }
        public void AddLast(T t)
        {
            if (head == null)
            {
                head = new Node();
                head.Next = head;
                head.Data = t;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.Data = t;
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = toAdd;
            }
        }
        public void PrintAllNode()
        {
            Node current = head!;
            while (current != null)
            {
                Console.Write($"{current.Data} ->");
                current = current.Next!;
            }
        }
    }
}
