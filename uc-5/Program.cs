using System;
class LinkedList
{

    // Head of list
    Node head;

    // Linked list Node
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }


    void deleteNode(int key)
    {
        // Store head node
        Node temp = head, prev = null;

        // If head node itself holds
        // the key to be deleted
        if (temp != null &&
            temp.data == key)
        {
            // Changed head
            head = temp.next;
            return;
        }

       
        while (temp != null &&
               temp.data != key)
        {
            prev = temp;
            temp = temp.next;
        }

        // If key was not present
        // in linked list
        if (temp == null)
            return;

        // Unlink the node from linked list
        prev.next = temp.next;
    }

    // Inserts a new Node at
    // front of the list.
    public void Push(int new_data)
    {
        Node new_node = new Node(new_data);
        new_node.next = head;
        head = new_node;
    }

    // This function prints contents
    // of linked list starting from
    // the given node
    public void printList()
    {
        Node tnode = head;
        while (tnode != null)
        {
            Console.Write(tnode.data + " ");
            tnode = tnode.next;
        }
    }

    // Driver code
    public static void Main(String[] args)
    {
        LinkedList list = new LinkedList();
       
        list.Push(56);
        list.Push(30);
        list.Push(70);


       

        Console.WriteLine("\nCreated Linked list is:");
        list.printList();

        // Delete node with data 1
        list.deleteNode(56);

        Console.WriteLine("\nLinked List after Deletion of 1:");
        list.printList();
    }
}