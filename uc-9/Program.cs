using System;
using System.Collections;
using System.Collections.Generic;

class Geeks
{

    // Main Method
    public static void Main(String[] args)
    {

        // Creating an List<T> of Integers
        List<int> list = new List<int>();

        // Adding elements to List
        list.Add(56);
        list.Add(30);
        list.Add(40);
        list.Add(70);
       

        Console.WriteLine("Elements Present in List:\n");

        int p = 0;

        // Displaying the elements of List
        foreach (int k in list)
        {
            Console.Write("At Position {0}: ", p);
            Console.WriteLine(k);
            p++;
        }

        Console.WriteLine(" ");

        // removing the element at index 3
        Console.WriteLine("Removing the element at index 3\n");

        // 9 will remove from the List
        // and 75 will come at index 3
        list.RemoveAt(3);

        int p1 = 0;

        // Displaying the elements of List
        foreach (int n in list)
        {
            Console.Write("At Position {0}: ", p1);
            Console.WriteLine(n);
            p1++;
        }
    }
}