using System;

public class myLinkedList
{
    private Node head;

    public void InsertHead(myLinkedList List, int data)
    {
        Node newNode = new Node(data);
        newNode.next = List.head;
        List.head = newNode;
    }

    public void InsertTail(myLinkedList List, int data)
    {
        Node newNode = new Node(data);
        if (List.head == null)
        {
            List.head = newNode;
            return;
        }
        Node lastNode = GetTail(List);
        lastNode.next = newNode;
    }

    public Node GetTail(myLinkedList List)
    {
        Node temp = List.head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        return temp;
    }

    public void InsertAfter(myLinkedList List, int numNode, int data)
    {
        Node temp = List.head;
        int i = 1;
        while (i!=numNode-1 && temp != null)
        {
            temp = temp.next;
            i++;
        }
        Node newNode = new Node(data);
        newNode.next = temp.next;
        temp.next = newNode;
    }

    public void DeleteNode(myLinkedList List, int key)
    {
        Node temp = List.head;
        Node prev = null;
        if (temp != null && temp.data == key)
        {
            List.head = temp.next;
            return;
        }
        while (temp != null && temp.data != key)
        {
            prev = temp;
            temp = temp.next;
        }
        if (temp == null)
        {
            return;
        }
        prev.next = temp.next;
    }

    public void Reverse(myLinkedList List)
    {
        Node prev = null;
        Node current = List.head;
        Node temp = null;
        while (current != null)
        {
            temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        List.head = prev;
    }

    public void printAllNodes(myLinkedList List)
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }
}
