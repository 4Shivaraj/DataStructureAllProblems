﻿using BinarySearchTreeNameSpace;
using HashTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Data Structure Program\n");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("\n1. Linked List \n2. Stack and Que \n3. Hash Table \n4. Binary Tree");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("Welcome to the LinkedList Program\n");

                    MyLinkedList linkedList = new MyLinkedList();
                    Console.WriteLine("Please choose an option");
                    Console.WriteLine("\n1. Add element at last position \n2. Add element at first position " +
                        "\n3. Add element at last position using Append method\n4. Insert element at perticular position" +
                        "\n5. Delete first element of Linkedlist\n6. Delete Last Element of Linkedlist\n7.Find Node with value" +
                        "\n8. Insert After value\n9. Delete particular value\n10. Ordered or sorted Linkedlist");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Add elements into Linkedlist using AddLast Method:");
                            linkedList.AddLast(56);
                            linkedList.AddLast(30);
                            linkedList.AddLast(70);
                            linkedList.Display();
                            break;
                        case 2:
                            Console.WriteLine("Add elements into Linkedlist using AddFirst Method:");
                            linkedList.AddFirst(70);
                            linkedList.AddFirst(30);
                            linkedList.AddFirst(56);
                            linkedList.Display();
                            break;
                        case 3:
                            Console.WriteLine("Add elements into Linkedlist using Append Method:");
                            linkedList.Append(56);
                            linkedList.Append(30);
                            linkedList.Append(70);
                            linkedList.Display();
                            break;
                        case 4:
                            Console.WriteLine("insert element at particular position:");
                            linkedList.Append(56);
                            linkedList.Append(70);
                            linkedList.Insert(1, 30);
                            linkedList.Display();
                            break;
                        case 5:
                            Console.WriteLine("Delete First Element:");
                            linkedList.AddLast(56);
                            linkedList.AddLast(30);
                            linkedList.AddLast(70);
                            linkedList.Display();
                            linkedList.DeleteFirstNode();
                            linkedList.Display();
                            break;
                        case 6:
                            Console.WriteLine("Delete last Element");
                            linkedList.AddLast(56);
                            linkedList.AddLast(30);
                            linkedList.AddLast(70);
                            linkedList.Display();
                            Console.WriteLine("\nLast element {0} is deleted", linkedList.DeleteFLastNode());
                            linkedList.Display();
                            break;
                        case 7:
                            Console.WriteLine("Find Element");
                            linkedList.AddLast(56);
                            linkedList.AddLast(30);
                            linkedList.AddLast(70);
                            linkedList.Display();
                            linkedList.Find(30);
                            break;
                        case 8:
                            Console.WriteLine("Insert After Value");
                            linkedList.AddLast(56);
                            linkedList.AddLast(30);
                            linkedList.AddLast(70);
                            linkedList.Display();
                            linkedList.InsertAfter(30, 40);
                            linkedList.Display();
                            break;
                        case 9:
                            Console.WriteLine("Delete particular value");
                            linkedList.AddLast(56);
                            linkedList.AddLast(30);
                            linkedList.AddLast(70);
                            linkedList.InsertAfter(30, 40);
                            linkedList.Display();
                            linkedList.DeleteElement(40);
                            linkedList.Size();
                            linkedList.Display();
                            break;
                        case 10:
                            Console.WriteLine("Sorted linkedlist");
                            linkedList.OrderedLinkedlist(56);
                            linkedList.OrderedLinkedlist(30);
                            linkedList.OrderedLinkedlist(40);
                            linkedList.OrderedLinkedlist(70);
                            linkedList.Display();
                            break;
                        default:
                            Console.WriteLine("Please enter the correct option");
                            break;
                    }
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Welcome to the Stack and Queue Program\n");

                    Stack stacks = new Stack();
                    Console.WriteLine("Please choose an option");
                    Console.WriteLine("\n1. Add element at last position \n2. Peek And Pop \n3. Create Queue \n4. Create DeQueue");
                    int menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Add element at last position");
                            stacks.Push(70);
                            stacks.Push(30);
                            stacks.Push(56);
                            stacks.Display();
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Peek And Pop");
                            stacks.Push(70);
                            stacks.Push(30);
                            stacks.Push(56);
                            stacks.Display();
                            stacks.IsEmpty();
                            stacks.Display();
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Create Queue");
                            Queue queues = new Queue();
                            queues.Enqueue(56);
                            queues.Enqueue(30);
                            queues.Enqueue(70);
                            queues.Display();
                            break;
                        case 4:
                            Console.WriteLine("Create DeQueue");
                            Queue queue = new Queue();
                            queue.Enqueue(56);
                            queue.Enqueue(30);
                            queue.Enqueue(70);
                            queue.Display();
                            queue.Dequeue();
                            queue.Display();
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Welcome to the HashTable program\n");

                    Console.WriteLine("Please choose an option");
                    Console.WriteLine("\n1. Finding Frequency Of Words \n2. Finding Frequency Of Words In Paragraph \n3. Remove Particular Word From Paragraph");
                    int menus = Convert.ToInt32(Console.ReadLine());
                    switch (menus)
                    {
                        case 1:
                            string paragraph = "To be or not to be";
                            FrequencyOfWords.GetFrequencyOfWords(paragraph);
                            Console.ReadLine();
                            break;
                        case 2:
                            string paragraphs = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                            FrequencyOfWords.GetFrequencyOfWords(paragraphs);

                            Console.ReadLine();
                            break;
                        case 3:
                            string paragraphss = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                            FrequencyOfWords.GetFrequencyOfWords(paragraphss);

                            Console.ReadLine();
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Welcome to the Binary Tree program\n");

                    Console.WriteLine("Please choose an option");
                    Console.WriteLine("\n1. Creating Binary Tree \n2. Find the size of tree \n3. Search node through the tree: ");
                    
                    int Optionss = Convert.ToInt32(Console.ReadLine());
                    switch (Optionss)
                    {

                        case 1:
                        Console.WriteLine("create My Binary Node: ");
                        BinarySearchTree<int> BinaryTrees = new BinarySearchTree<int>();
                        BinaryTrees.AddNode(56);
                        BinaryTrees.AddNode(30);
                        BinaryTrees.AddNode(70);
                        BinaryTrees.AddNode(22);
                        BinaryTrees.AddNode(40);
                        BinaryTrees.AddNode(11);
                        BinaryTrees.AddNode(63);
                        BinaryTrees.AddNode(67);
                        BinaryTrees.AddNode(16);
                        BinaryTrees.AddNode(60);
                        BinaryTrees.AddNode(95);
                        BinaryTrees.AddNode(65);
                        BinaryTrees.AddNode(3);
                        break;

                        case 2:
                        Console.WriteLine("Find the size of tree: ");
                        BinarySearchTree<int> BinaryTreees = new BinarySearchTree<int>();
                        BinaryTreees.AddNode(56);
                        BinaryTreees.AddNode(30);
                        BinaryTreees.AddNode(70);
                        BinaryTreees.AddNode(22);
                        BinaryTreees.AddNode(40);
                        BinaryTreees.AddNode(11);
                        BinaryTreees.AddNode(63);
                        BinaryTreees.AddNode(67);
                        BinaryTreees.AddNode(16);
                        BinaryTreees.AddNode(60);
                        BinaryTreees.AddNode(95);
                        BinaryTreees.AddNode(65);
                        BinaryTreees.AddNode(3);
                        int Size = BinaryTreees.GetSize();
                        Console.WriteLine(Size);
                        break;

                        case 3:
                        Console.WriteLine("Search node through the tree: ");
                            BinarySearchTree<int> Binary = new BinarySearchTree<int>();
                            Binary.AddNode(56);
                            Binary.AddNode(30);
                            Binary.AddNode(70);
                            Binary.AddNode(22);
                            Binary.AddNode(40);
                            Binary.AddNode(11);
                            Binary.AddNode(63);
                            Binary.AddNode(67);
                            Binary.AddNode(16);
                            Binary.AddNode(60);
                            Binary.AddNode(95);
                            Binary.AddNode(65);
                            Binary.AddNode(3);
                            
                            bool result = Binary.SearchKey(63);
                        Console.WriteLine(result);
                        break;
                    }
                    break;
            }
        }
    }
}

//UC-3
//Ability to search 63 in the Binary Tree
//- Implement Search method and recursively search left or right nodes to find 63

//Result
//Welcome to the Binary Tree program

//Please choose an option

//1. Creating Binary Tree
//2. Find the size of tree
//3. Search node through the tree:
//3
//Search node through the tree:
//True
