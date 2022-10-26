

public class HasMap
{
    public static void DrivingCode()
    {
        //Fi000nd the sum array with given sum
        PracIDictionary();

        int[] a = { 2, 45, 7, 3, 5, 1, 8, 9 };
        //method : codaddict's algorithm : O(n)
        checkPairs(a, 10);
        Console.Read();
    }
    static void PracIDictionary()
    {
        Dictionary<int, int> map =new Dictionary<int, int>();

        map.Add(1, 2);
        map.Add(2, 2);
        map.Add(3, 2);

        foreach(KeyValuePair<int, int> pair in map)
        {
            Console.WriteLine("KEY: " + pair.Key);
            Console.WriteLine("VALUE: " + pair.Value);

        }

    }

    static void checkPairs(int[] input, int k)
    {
        Dictionary<int, int> Pairs = new Dictionary<int, int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (Pairs.ContainsKey(input[i]))
            {
                Console.WriteLine(input[i] + ", " + Pairs[input[i]]);
            }
            else
            {
                Pairs[k - input[i]] = input[i];
            }
        }
    }
    
}