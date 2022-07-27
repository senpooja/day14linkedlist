﻿using System;

class GFG
{

    // Link list node /
    public class Node
    {
        public int data;
        public Node next;
    };

    // Function to remove the last node
    // of the linked list /
    static Node removeLastNode(Node head)
    {
        if (head == null)
            return null;

        if (head.next == null)
        {
            return null;
        }

        // Find the second last node
        Node second_last = head;
        while (second_last.next.next != null)
            second_last = second_last.next;

        // Change next of second last
        second_last.next = null;

        return head;
    }

    // Function to push node at head
    static Node push(Node head_ref, int new_data)
    {
        Node new_node = new Node();
        new_node.data = new_data;
        new_node.next = (head_ref);
        (head_ref) = new_node;
        return head_ref;
    }

    // Driver code
    public static void Main(String[] args)
    {
        // Start with the empty list /
        Node head = null;

        // Use push() function to construct
        // the below list 8 . 23 . 11 . 29 . 12 /
        head = push(head, 56);
        head = push(head, 30);
        head = push(head, 70);

     

        head = removeLastNode(head);
        for (Node temp = head; temp != null; temp = temp.next)
            Console.Write(temp.data + " ");
    }
}
