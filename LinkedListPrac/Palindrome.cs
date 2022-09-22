

public class Palindrome
{
    public static void DrivingCode()
    {
        
        Node head = new Node(12);
        Node h1 = new Node(13);
        //Node h2 = new Node(14);
        // Node h3 = new Node(1);
        // Node h4 = new Node(14);
        // Node h5 = new Node(13);
        // Node h6 = new Node(12);

        head.Next = h1;
        //h1.Next = h2;
       // h2.Next = h3;
        // h3.Next = h4;
        // h4.Next = h5;
        // h5.Next = h6;

        


       bool res = PalendromeMethod(head);
        Console.WriteLine(res);
    }

    static bool PalendromeMethod(Node head)
    {        
        if(head == null)
        {
            Console.WriteLine("Node Empty");
            return false;
        }

        Node mid = MidNode(head);
        
        Node last = Reverse(mid.Next);

        Node cur = head;

        while(last != null)
        {
            if(last.data != cur.data)
                return false;
            
            last = last.Next;
            cur = cur.Next;
        }

        return true;

         
    }

    static Node MidNode(Node head)
    {
        Node fast = head;
        Node slow = head;

        while(fast != null && fast.Next != null)
        {            
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        return slow;
    }

    static Node Reverse(Node head)
    {
        
        if(head == null || head.Next == null)
        {
            return head;
        }    

        Node newNode = Reverse(head.Next);
        head.Next.Next = head;
        head.Next = null;

        return newNode;
    }

}