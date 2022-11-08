using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"{node.data} is Inserted in Linked List");
        }
        public void InsertAtParticularPosition(int position, int data)
        {
            Node temp = head;
            int postion1=position;
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                Node newNode = new Node(data);
                newNode.next = temp;
                temp = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        var node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            Console.WriteLine();
            Console.WriteLine($"Inserted value is : {data} at node {postion1}");
        }
        public void RemoveFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("The Linked List is Empty");
            }
            head = head.next;
        }
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("The Linked List is Empty");
            }
            if (head.next == null)
            {
                Console.WriteLine("Only One Element in Linked List to Remove that Element Please Use Remove First Function");
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
        }
        public void Search(int value)
        {
            int Count = 1;
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine($"\nThe {value} is at Node : " + Count);
                }
                temp = temp.next;
                Count++;
            }
        }
        public void DeleteNodeAtPerticularPosition(int position)
        {
            if (head == null)
            {
                return;
            }
            Node temp = head;
            if (position == 0)
            {
                head = temp.next;
                return;
            }
            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next1 = temp.next.next;
            temp.next = next1;
        }
        public void sortedInsert(Node new_node)
        {
            Node current;

            if (head == null || head.data >= new_node.data)
            {
                new_node.next = head;
                head = new_node;
            }
            else
            {
                current = head;

                while (current.next != null && current.next.data < new_node.data)
                    current = current.next;

                new_node.next = current.next;
                current.next = new_node;
            }
        }
        public Node newNode(int data)
        {
            Node x = new Node(data);
            return x;
        }
        public void Display()
        {

            int i = 1;
            Node temp = head;

            Console.WriteLine();
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($"Element {i} in Linked List is : " + temp.data);
                temp = temp.next;
                i++;

            }
        }
    }
}
