
public class LeetPrac
{
    public static void DrivingCode()
    {
        //find Unique number in array
        int[] arr = {1,1,2,3,2,4,4};

        int ans = FindUnique(arr);
        Console.WriteLine(ans);
        int[] arr1 = {2,7,11,15, -10, -1};
        int[] ans1 = TwoSum(arr1, 9);
        Console.WriteLine();
        for (int i = 0; i < ans1.Length; i++)
        {
            Console.WriteLine(ans1[i]);
        }
    }
    static int[] TwoSum(int[] nums, int target) 
    {
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                int sum = nums[i] + nums[j];
                //Console.WriteLine("Sum = " + sum);
                if(sum == target)
                {
                    return new int[]{i,j};
                }
            }
        }

        return null;

    }

    static int FindUnique(int[] arr)
    {
        int ans = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            ans = ans ^ arr[i];
        }

        return ans;
    }
}