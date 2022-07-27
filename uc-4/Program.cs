using System;

public class LinkedList
{
    static Node head; // head of list

    /* Node Class */
    public class Node
    {
        public int data;
        public Node next;

        // Constructor to create a new node
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    // function to insert node at the
    // middle of the linked list
    static void insertAtMid(int x)
    {
        // if list is empty
        if (head == null)
            head = new Node(x);
        else
        {
            // get a new node
            Node newNode = new Node(x);

            Node ptr = head;
            int len = 0;

            // calculate length of the linked list
            //, i.e, the number of nodes
            while (ptr != null)
            {
                len++;
                ptr = ptr.next;
            }

            // 'count' the number of nodes after which
            // the new node is to be inserted
            int count = ((len % 2) == 0) ? (len / 2) :
                                        (len + 1) / 2;
            ptr = head;

            // 'ptr' points to the node after which
            // the new node is to be inserted
            while (count-- > 1)
                ptr = ptr.next;

            // insert the 'newNode' and adjust
            // the required links
            newNode.next = ptr.next;
            ptr.next = newNode;
        }
    }

    // function to display the linked list
    static void display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
    }

    // Driver code
    public static void Main()
    {
        // Creating the list 1.2.4.5
        head = null;
        head = new Node(56);
        head.next = new Node(70);
   

        Console.WriteLine("Linked list before " +
                        "insertion: ");
        display();

        int x = 30;
        insertAtMid(x);
        

        Console.WriteLine("\nLinked list after" +
                        " insertion: ");
        display();
    }
}