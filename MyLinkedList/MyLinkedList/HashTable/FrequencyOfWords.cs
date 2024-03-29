﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class FrequencyOfWords
    {
        public static void GetFrequencyOfWords(string paragraph)
        {
            MyMapNode<string, int> hashTable = new MyMapNode<string, int>(8);
            string[] words = paragraph.Split(' ');
            foreach (string word in words)
            {
                if (hashTable.Exists(word))
                {
                    hashTable.Add(word.ToLower(), hashTable.Get(word.ToLower()) + 1);
                }
                else
                {
                    hashTable.Add(word.ToLower(), 1);
                }
            }
            Console.WriteLine("Displaying after Add operatopn:");
            hashTable.Display();

            string removeThis = "avoidable";
            hashTable.Remove(removeThis);
            Console.WriteLine("\nAfter removing an item- {0}:", removeThis);
            hashTable.Display();
        }
    }
}