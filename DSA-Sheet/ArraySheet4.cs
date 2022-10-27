
public class ArraySheet4
{
    public static void DrivingCode()
    {
        int[] arr= {-12, 11, -13, -5, 6, -7, 5, -3, -6};

        MoveAllNegativeBeginning(arr, arr.Length);
    }
    static void MoveAllNegativeBeginning(int[] arr, int index, int n, int[] arrAns)
    {
        
        int curIndex = arr[index];
        if(curIndex < 0)
        {
            arrAns[index] = curIndex;
        }

    }
}