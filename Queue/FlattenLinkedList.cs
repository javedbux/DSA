
public class FlattenLinkedList
{
   static Node head;

   public Node createList() 
    {
        int []arr1 = new int[]{10, 5, 12, 7, 11};
        int []arr2 = new int[]{4, 20, 13};
        int []arr3 = new int[]{17, 6};
        int []arr4 = new int[]{9, 8};
        int []arr5 = new int[]{19, 15};
        int []arr6 = new int[]{2};
        int []arr7 = new int[]{16};
        int []arr8 = new int[]{3};
  
        /* create 8 linked lists */
        Node head1 = createList(arr1, arr1.Length);
        Node head2 = createList(arr2, arr2.Length);
        Node head3 = createList(arr3, arr3.Length);
        Node head4 = createList(arr4, arr4.Length);
        Node head5 = createList(arr5, arr5.Length);
        Node head6 = createList(arr6, arr6.Length);
        Node head7 = createList(arr7, arr7.Length);
        Node head8 = createList(arr8, arr8.Length);
  
        /* modify child pointers to
        create the list shown above */
        head1.child = head2;
        head1.next.next.next.child = head3;
        head3.child = head4;
        head4.child = head5;
        head2.next.child = head6;
        head2.next.next.child = head7;
        head7.child = head8;
  
        /* Return head pointer of first 
        linked list. Note that all nodes
         are reachable from head1 */
        return head1;
    }

   public Node createList(int []arr, int n) 
    {
        Node node = null;
        Node p = null;
          
        int i;
        for (i = 0; i < n; ++i) 
        {
            if (node == null) 
            {
                node = p = new Node(arr[i]);
            } 
            else 
            {
                p.next = new Node(arr[i]);
                p = p.next;
            }
            p.next = p.child = null;
        }
        return node;
    }
  
    // A utility function to print 
    // all nodes of a linked list
   public void printList(Node node)
    {
        while (node != null) 
        {
            Console.Write(node.data + " ");
            node = node.next;
        }
        Console.WriteLine("");
    }

  /* The main function that flattens 
    a multilevel linked list */
    public void FlattenList(Node node)
    {
        //base case
        if(node == null)
            return;
        
        Node temp = null;

        Node tail = node;

        while(tail != null)
        {
            tail = tail.next;
        }

        Node cur = node;
        
        while(cur != tail)
        {
            if(cur.child != null)
            {
                tail.next = cur.child;

                temp = cur.child;

                while(temp.next != null)
                {
                    temp = temp.next;
                }
                tail =temp;
            }

            cur = cur.next;
        }        
    }

    public  void DrivingCode() 
    {
        
        head = createList();
        FlattenList(head);
        printList(head);
    }
}