using System;

namespace InsertIntoLinkedList
{
    class Program
    {
        // A linked list Node
        private class Node
        {
            public int data;
            public Node nextNode;

            // inserting the required data 
            public Node(int data) => this.data = data;
        }

        // function to create and return a Node 
        static Node GetNode(int data) => new Node(data);

        // function to insert a Node at required position 
        static Node InsertPos(Node headNode,
                            int position, int data)
        {
            var head = headNode;
            if (position < 1)
                Console.WriteLine("Invalid position");

            //if position is 1 then new node is 
            // set infornt of head node
            //head node is changing.
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.nextNode = headNode;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        // adding Node at required position
                        Node newNode = GetNode(data);

                        // Making the new Node to point to 
                        // the old Node at the same position 
                        newNode.nextNode = headNode.nextNode;

                        // Replacing current with new Node 
                        // to the old Node to point to the new Node 
                        headNode.nextNode = newNode;
                        break;
                    }
                    headNode = headNode.nextNode;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.Write(node.data);
                node = node.nextNode;
                if (node != null)
                    Console.Write(",");
            }
            Console.WriteLine();
        }

        // Driver code
        static void Main(string[] args)
        {
            var head = GetNode(56);
            head.nextNode = GetNode(30);
            head.nextNode.nextNode = GetNode(70);
           

            Console.WriteLine("Linked list before insertion: ");
            PrintList(head);

            int data = 40, pos = 3;
            head = InsertPos(head, pos, data);
            Console.WriteLine("Linked list after" +
                            " insertion of 12 at position 3: ");
            PrintList(head);

        

          
        }
    }
}