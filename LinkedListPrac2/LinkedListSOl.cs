
using System;
public class LinkedListSOL
{
   public Node head;
    int size;
    public LinkedListSOL()
    {
        this.size = 0;
    }



    public void AddFirst(int data)
    {
        size++;
        Node newNode = new Node(data);

        if(head == null)
        {
            head = newNode;
            return;
        }

        newNode.Next = head;
        head = newNode;

        
    }

    public void AddLast(int data)
    {
        Node newNode = new Node(data);

        if(head == null)
        {
            head = newNode;
            return;
        }

        Node cur = head;

        while(cur.Next != null)
        {
            cur = cur.Next;
        }

        cur.Next = newNode;

        size++;
    }

    public void PrintList()
    {
        if(head == null)
        {
            Console.WriteLine("Nod eis empty");
            return;            
        }

        Node cur  = head;

        while(cur != null)
        {
            Console.Write(" > " + cur.data);
            cur = cur.Next;
        }

    }

    //Delete First
    public void DeleteFirst()
    {
        if(head == null)
        {
            Console.WriteLine("List is Null");
            return;
        }
        size--;
        head = head.Next;
    }

    public void DeleteLast()
    {
        if(head == null)
        {
            Console.WriteLine("List is Null");
            return;
        }
        size--;
        if(head.Next == null)
        {
            head = null;
            return;
        }

        Node lastNode = head.Next;
        Node secondLast = head;

        while(lastNode.Next != null)
        {
            lastNode = lastNode.Next;
            secondLast = secondLast.Next;
        }

        secondLast.Next = null;

    }

    public int GetSize()
    {
        return size;
    }
    
}