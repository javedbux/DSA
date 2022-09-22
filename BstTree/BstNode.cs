
public class BstNode
{
    public static void DrivingCode()
    {
        int[] arr = {5,2,3,4,7,6,1};

        Node root = null;

        //Insert
        for(int i=0; i < arr.Count(); i++)
        {
            root = Insert(root, arr[i]);
        }

        InOrder(root);
        Console.WriteLine();

        //search
        if(SearchValueBst(root, 1))
            Console.WriteLine("Found");
        else
            Console.WriteLine("Not Found");

        DeleteNode(root, 4);

        InOrder(root);
        Console.WriteLine();

    }

    static Node DeleteNode(Node root, int key)
    {
        if(root == null)
            return root;
        
        if(root.data > key)
        {
            root.left = DeleteNode(root.left, key);
        }
        else if(root.data < key)
            {
                root.right = DeleteNode(root.right, key);
            }
        else{
            // case 1
            if(root.left == null && root.right == null)
            {
                return null;
            }

            //case 2
            if(root.left == null)
            {
                return root.right;
            } 
            else //case 2
                if(root.right == null)
                    return root.left;

            // case 3   InOrderSuccessor
            Node IS = InOrderSuccessor(root.right);
            root.data = IS.data;
            root.right = DeleteNode(root.right, IS.data); 
        }

        return root;
        
    }

    static Node InOrderSuccessor(Node root)
    {
        while(root.left != null)
        {
            root = root.left;
        }

        return root;
    }

    static bool SearchValueBst(Node root, int key)
    {
        if(root == null)
            return false;

        if(key < root.data)
        {
            return SearchValueBst(root.left, key);
        }
        else if(key == root.data)
            return true;
        else
            return SearchValueBst(root.right, key);
    }


    static void InOrder(Node root)
    {
        if(root == null)
            return;

        InOrder(root.left);
        Console.Write(" " + root.data);
        InOrder(root.right);
    }

    static Node Insert(Node root, int val)
    {
        if(root == null)
        {
            root = new Node(val);
            return root;
        }

        if(val < root.data)
        {
            root.left = Insert(root.left, val);
        }
        else
        {
            root.right  = Insert(root.right, val);
        }

        return root;

    }
}