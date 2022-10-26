
public class ArraySheet1
{
    public static void DrivingCode()
    {
        int[] arr= {0, 2, 1, 2, 0};
        sort012(arr, arr.Length);
    }
    static void sort012(int[] arr, int n)
    {
        // code here 
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[i] + " " + arr[j]);
            }
        }
        
    }
}