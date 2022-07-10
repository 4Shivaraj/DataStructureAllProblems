using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Program");

            MyLinkedList linkedList = new MyLinkedList();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            linkedList.Display();

            Console.ReadLine();
        }
    }
}
//UC-1
//Lets create a simple Linked List of 56, 30 and 70

//Result
//Welcome to the LinkedList Program
//56 is inserted into LinkedList
//30 is inserted into LinkedList
//70 is inserted into LinkedList
//Displaying Nodes:
// 56  30  70