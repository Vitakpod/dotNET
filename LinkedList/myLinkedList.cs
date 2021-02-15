using System;

public class myLinkedlist
{
    private Node head;

    public void InsertHead(myLinkedlist list, int data)
    {
        Node newNode = new Node(data);
        newNode.next = list.head;
        list.head = newNode;
    }

    public void InsertTail(myLinkedlist list, int data)
    {
        Node newNode = new Node(data);
        if (list.head == null)
        {
            list.head = newNode;
            return;
        }
        Node lastNode = GetTail(list);
        lastNode.next = newNode;
    }

    public Node GetTail(myLinkedlist list)
    {
        Node temp = list.head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        return temp;
    }

    public void InsertAfter(myLinkedlist list, int numNode, int data)
    {
        Node temp = list.head;
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

    public void DeleteNode(myLinkedlist list, int key)
    {
        Node temp = list.head;
        Node prev = null;
        if (temp != null && temp.data == key)
        {
            list.head = temp.next;
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

    public void Reverse(myLinkedlist list)
    {
        Node prev = null;
        Node current = list.head;
        Node temp = null;
        while (current != null)
        {
            temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        list.head = prev;
    }

    public void printAllNodes(myLinkedlist list)
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }
}
