using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace collections
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = new int[3];
      // two dimentional array
      int[,] twoDimentionalArr = new int[2, 3];

      // int[] arr1 = new int[] { 2, 3, 4 };

      // default values of numeric elements of array are set to zero.
      foreach (int i in arr)
      {
        Console.WriteLine(i);
      }

      // Queue

      Queue q = new Queue();
      q.Enqueue("'first'");
      q.Enqueue("second");
      q.Enqueue("third");
      q.Dequeue();

      foreach (string st in q)
      {
        Console.WriteLine(st);

      }

      // Generic Collections

      // Dictionary

      Dictionary<string, int> myDictionary = new Dictionary<string, int>();
      myDictionary.Add("first", 1);
      myDictionary.Add("second", 2);

      // When you use foreach to enumerate dictionary elements,
      // the elements are retrieved as KeyValuePair objects.

      Console.WriteLine();
      foreach (KeyValuePair<string, int> kvp in myDictionary)
      {
        Console.WriteLine("Key = {0}, Value = {1}",
            kvp.Key, kvp.Value);
      }

      // To get the keys alone, use the KeyCollection property.

      Dictionary<string, int>.KeyCollection keyColl =
          myDictionary.Keys;

      // The elements of the KeyCollection are strongly typed
      // with the type that was specified for dictionary keys.

      Console.WriteLine();
      foreach (string s in keyColl)
      {
        Console.WriteLine("Key = {0}", s);
      }

      // The Add method throws an exception if the new key is
      // already in the dictionary.

      try
      {
        myDictionary.Add("first", 10);
      }
      catch (ArgumentException)
      {
        Console.WriteLine("An element with Key = \"first\" already exists.");
      }

      // Stack

      Stack<string> myStack = new Stack<string>();
      myStack.Push("first");
      myStack.Push("second");
      myStack.Push("third");
      myStack.Push("fourth");

      myStack.Pop();

      foreach (string st in myStack)
      {
        Console.WriteLine(st);
      }



      // List<string> st = new List<string>() { "me", "you" };
      // Console.WriteLine(System.GC.GetGeneration(st));
      // System.GC.Collect(0);

      // Console.WriteLine(System.GC.GetGeneration(st));
      // System.GC.Collect(2);

      // Console.WriteLine(System.GC.GetGeneration(st));

      // Console.WriteLine(System.GC.GetTotalMemory(false));
    }

  }
}
