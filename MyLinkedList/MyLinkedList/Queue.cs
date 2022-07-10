using MyLinkedList.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    class Queue
    {
        public Node head;
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted into Queue", newNode.data);
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("\n{0} is dequeued from queue", this.head.data);
                this.head = this.head.next;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}