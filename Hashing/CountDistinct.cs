

using System;
using System.Collections.Generic;
public class CountDistinct
{
    public static void DrivingCode()
    {
        // HashSet<int> arr = new HashSet<int>() {
        //     5,3,5,10,3,4
        // };
        int[] arr = {5,3,5,10,3,4};
        int ans = ReturnDistinct(arr);
        Console.WriteLine(ans);

        int[] b = {5,3,5,23,12};
        int unionSize = ReturnUnionSize(arr, b);
        Console.WriteLine(unionSize);

    }

    static int ReturnDistinct(int[] arr)
    {
        HashSet<int> set =new HashSet<int>();
        int ans =0;

        foreach(var val in arr)
        {
            set.Add(val);
        }

        return set.Count;
    }

    static int ReturnUnionSize(int[] a, int[] b)
    {
        HashSet<int> set = new HashSet<int>();

        foreach(var aa in a)
        {
            set.Add(aa);
        }

        foreach(var bb in b)
        {
            set.Add(bb);
        }
        Console.WriteLine("-----------");
        foreach(var se in set)
        {
            Console.WriteLine(se);
        }

        return set.Count;
    }
}