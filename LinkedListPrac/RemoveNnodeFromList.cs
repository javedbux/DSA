

public class RemoveNnodeFromList
{
    public static void DrivingCode()
    {
        
        Node head = new Node(12);
        Node h1 = new Node(13);
        Node h2 = new Node(14);
        Node h3 = new Node(1);
        Node h4 = new Node(141);
        Node h5 = new Node(131);
        Node h6 = new Node(121);

        head.Next = h1;
        h1.Next = h2;
        h2.Next = h3;
        h3.Next = h4;
        h4.Next = h5;
        h5.Next = h6;

        
        // Node res = NthNodeInList(head,3);
        
        // while(res !=null)
        // {
        //     Console.WriteLine("Remove node + " + res.data);
        //     res = res.Next;
        // }     

        int ans = getNthFromLast(head, 4);

        Console.WriteLine("N th node = " + ans);

    }

    static int getNthFromLast(Node head, int k)
    {
        if(head == null)
            return -1;

        int size =0;
        Node cur  = head;
        while(cur != null)
        {
            cur = cur.Next;
            size++;
        }

        int nthFromIndex = size-k;
        int i =1;
        Node pres = head;

        while(i != nthFromIndex)
        {
            pres = pres.Next;
            i++;
        }

        int res = pres.data;

        return res;

    }

    static Node NthNodeInList(Node head, int n)
    {
        if(head == null)
            return null;
        
        
        int size =0;
        Node cur = head;
        while(cur != null)
        {
            cur =cur.Next;
            size++;
        }

        int nth = size - n;

        Node newNode = head;
        int i =1;
        while(i != nth)
        {          
            //Console.WriteLine("Nth node = " + i + " " + newNode.data);    
            newNode = newNode.Next;
            i++;
              
        }
        //Console.WriteLine("Nth node = " + newNode.data);

        newNode.Next  = newNode.Next.Next; 

        return head;
    }

}