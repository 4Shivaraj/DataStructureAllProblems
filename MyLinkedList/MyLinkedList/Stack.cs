using StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    public class Stack
    {
        public Node top;
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = this.top;
            this.top = newNode;
            Console.WriteLine("{0} pushed to the stack", data);
        }
        public void Display()
        {
            Node temp = this.top;
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