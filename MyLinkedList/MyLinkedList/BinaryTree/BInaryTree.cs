using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeNameSpace
{
    public class BinarySearchTree<K> where K : IComparable
    {
        //Node root variable create to store the first node as root
        public BinarySearchTreeNode<K> Root;                //First Node

        public void AddNode(K Key)                              //Key value added
        {
            Root = AddRecursively(Root, Key);               //Root is intially null
        }
        public K GetRoot { get { return Root.Key; } }
        public K GetRootLeft { get { return Root.Left.Key; } }
        public K GetRootRight { get { return Root.Right.Key; } }



        private BinarySearchTreeNode<K> AddRecursively(BinarySearchTreeNode<K> Current, K Key)  //Current = 
        {
            //Check node is created or not and create Node
            //After Comparision current value become null to create new node and add to position
            if (Current == null)                                    //Intial Position Current position is empty
                return new BinarySearchTreeNode<K>(Key);

            //Comapre the Node with Current(Root) Node
            int CompareResult = Key.CompareTo(Current.Key);
            //Comparision answer is zero then return current  node  // if value is identical or same than value will be same 
            if (CompareResult == 0)
                return Current;
            //If comparision ans is smaller then go to left
            //If comparision ans is larger than go to right
            if (CompareResult < 0)
                Current.Left = AddRecursively(Current.Left, Key);

            else
                Current.Right = AddRecursively(Current.Right, Key);
            return Current;

        }

    }
}
//UC-1
//Ability to create a BST by adding 56 and then adding 30 & 70
//- Use INode to create My Binary Node
//- Note the key has to extend comparable to compare and determine left or right node
//- First add 56 as root node so 30 will be
//added to left and 70 to right