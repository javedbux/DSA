
public class KElementUsingAVL
{
    public static void DrivingCode()
    {
        int[] arr = { 12, 1, 78, 90, 57, 89, 56 };
        int K = 3;
       
          // Function call
        printMax(arr, arr.Length, K);
    }

    static void printMax(int[] arr, int n, int k)
    {

        List<int> deQ = new List<int>();

        for(int i=0; i< k; i++)
        {
            while (deQ.Count != 0
                   && arr[i] >= arr[deQ[deQ.Count - 1]])

            
            deQ.Insert(deQ.Count, i);
        }


        for(int i = 0; i< n; ++i)
        {
            Console.Write(deQ[0] + " ");

            while((deQ.Count != 0) && deQ[0] <= i-k)
                deQ.RemoveAt(0);

            while ((deQ.Count != 0)
                   && arr[i] >= arr[deQ[deQ.Count - 1]])
                deQ.RemoveAt(deQ.Count - 1);
 
            deQ.Insert(deQ.Count, i);
        }

        // Print the maximum element of last window
        Console.Write(arr[deQ[0]]);
    }

}