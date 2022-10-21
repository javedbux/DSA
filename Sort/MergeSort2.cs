
public class MergeSort2
{
    public static void DrivingCode()
    {
        int[] arr = {23,1,4,3,78,6,9};
        int n = arr.Length;
        Divide(arr, 0, n-1 );

        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + arr[i]);
        }
        Console.WriteLine();
    }

    static void Divide(int[] arr, int si, int ei)
    {
        if( si >= ei)
        {
            return;
        }
        int mid = si + (ei -si)/2; // 
        Divide(arr, si, mid);
        Divide(arr, mid +1, ei);
        Conquer(arr, si, mid, ei);
    }

    static void Conquer(int[] arr, int si, int mid, int ei)
    {
        int[] merged = new int[ei -si +1];
        int idx1 = si;
        int idx2 = mid +1;
        int x =0;

        while(idx1 <= mid && idx2 <= ei)
        {
            if(arr[idx1] < arr[idx2])
            {
                merged[x++] = arr[idx1++];
            }
            else
            {
                merged[x++] = arr[idx2++];
            }
        }

        while(idx1 <= mid)
        {
            merged[x++] = arr[idx1++];
        }

        while(idx2 <= ei)
        {
            merged[x++] = arr[idx2++];
        }

        for (int i = 0, j= si; i < merged.Length; i++, j++)
        {
            arr[j] = merged[i];
        }       

    }
}