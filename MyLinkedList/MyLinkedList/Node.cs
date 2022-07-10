using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList.LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node top;

        public Node(int data)
        {
            this.data = data;
            top = null;
            next = null;
        }
    }
}