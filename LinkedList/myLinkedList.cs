using System;

public class myLinkedList
{
    private Node head;

    public void InsertHead(myLinkedList singleList, int data)
    {
        Node newNode = new Node(data);
        newNode.next = singleList.head;
        singleList.head = newNode;
    }

    public void InsertTail(myLinkedList singleList, int data)
    {
        Node newNode = new Node(data);
        if (singleList.head == null)
        {
            singleList.head = newNode;
            return;
        }
        Node lastNode = GetTail(singleList);
        lastNode.next = newNode;
    }

    public Node GetTail(myLinkedList singleList)
    {
        Node temp = singleList.head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        return temp;
    }

    public void InsertAfter(myLinkedList singleList, int numNode, int data)
    {
        Node temp = singleList.head;
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

    public void DeleteNode(myLinkedList singleList, int key)
    {
        Node temp = singleList.head;
        Node prev = null;
        if (temp != null && temp.data == key)
        {
            singleList.head = temp.next;
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

    public void Reverse(myLinkedList singleList)
    {
        Node prev = null;
        Node current = singleList.head;
        Node temp = null;
        while (current != null)
        {
            temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        singleList.head = prev;
    }

    public void printAllNodes(myLinkedList singleList)
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }
}
