using System;

public class myLinkedList
{
    private Node head;

    public void InsertHead(myLinkedList singleList, int data)
    {
        Node new_node = new Node(data);
        new_node.next = singleList.head;
        singleList.head = new_node;
    }

    public void InsertTail(myLinkedList singleList, int data)
    {
        Node new_node = new Node(data);
        if (singleList.head == null)
        {
            singleList.head = new_node;
            return;
        }
        Node lastNode = GetTail(singleList);
        lastNode.next = new_node;
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

    public void InsertAfter(Node prev_node, int data)
    {
        if (prev_node == null)
        {
            Console.WriteLine("The given previous node should exist!");
            return;
        }
        Node new_node = new Node(data);
        new_node.next = prev_node.next;
        prev_node.next = new_node;
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
