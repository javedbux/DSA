
public class Ques
{
    public static void DrivingCode()
    {
        int[] arr = {4,1,2,3,5,1,2,3};

        int ans = DistinctElement(arr);
        Console.WriteLine(ans);

        Console.WriteLine("Union to Array");

        int[] a = {5,10,15,5,10};
        int[] b = {15,5,5,10,4};

        UnionAllArray(a, b);

        Console.WriteLine();

        Intersect(a,b);

    }

    static void Intersect(int[] a, int[] b)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (var item in a)
        {
            set.Add(item);
        }


        HashSet<int> set1 = new HashSet<int>();

        foreach (var item in b)
        {
            set1.Add(item);
        }

        set.IntersectWith(set1);

        Console.WriteLine(set.Count);
        
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
    }

    static void UnionAllArray(int[] a, int[] b)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (var item in a)
        {
            set.Add(item);
        }

        foreach (var item in b)
        {
            set.Add(item);
        }

        foreach (var item in set)
        {
            Console.Write(" "+ item);
        }

        set.Reverse();        
        Console.WriteLine();
        Console.WriteLine(" Count after union " +set.Count);
        Console.WriteLine();

        foreach (var item in set)
        {
            Console.Write(" "+ item);
        }

    }

    static int DistinctElement(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (var item in arr)
        {
            set.Add(item);
        }

        return set.Count;
    }
}