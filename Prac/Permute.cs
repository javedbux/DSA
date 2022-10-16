
using System.Collections;
public class Permute
{
    public static void DrivingCode()
    {
        string str = "abc";

        Permutation(str, 0, "");
        Console.WriteLine();

        //CountPathMaze
        Console.WriteLine("CountPathMaze");
        int ans = CountPathMaze(3, 3);
        Console.WriteLine(ans);

        Console.WriteLine();
        Console.WriteLine("CountPathMazeWithI");
        int ans1 = CountPathMazeWithI(3, 3, 0, 0);
        Console.WriteLine(ans1);

        //Tiling problem 
        Console.WriteLine();
        Console.WriteLine("Tiling problem");
        int ans2 = TilingProblem(4, 2);
        Console.WriteLine(ans2);

        //Friends pairing problem 
        Console.WriteLine();
        Console.WriteLine("Friends pairing problem");
        int ans3 = FriendsPairingProblem(4);
        Console.WriteLine(ans3);


        Console.WriteLine();
        Console.WriteLine("Subsets of a set");
        ArrayList set = new ArrayList();
        SubsetsOfASet(3 , set);
    }

    static void SubsetsOfASet(int n, ArrayList set)
    {
        if(n == 0)
        {
            PrintSet(set);
            return;
        }

        // add hoga
        set.Add(n);
        SubsetsOfASet(n -1, set);

        // Remove hoga
        set.RemoveAt(set.Count -1);
        SubsetsOfASet(n -1, set);
    }

    static void PrintSet(ArrayList set)
    {
        foreach(var item in set)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine();
    }

    static int FriendsPairingProblem(int n)
    {
        if(n <= 1)
        {
            return 1;
        }

        int single = FriendsPairingProblem(n-1);
        int pair = (n -1) * FriendsPairingProblem(n -2);

        return single + pair;
    }
    static int TilingProblem(int n, int m)
    {
        if(n == m)
        {
            return 2;
        }
        if(n <= m)
        {
            return 1;
        }
        int horizontal = TilingProblem(n - m, m);
        int vertical = TilingProblem(n -1, m);

        return horizontal + vertical;
    }



    static int CountPathMazeWithI(int n, int m, int i, int j)
    {
        if(n == i || m == j)
            return 0;
        
        if(i == n -1 && j == m - 1)
        {
            return 1;
        }


        int downPath = CountPathMazeWithI(n, m, i + 1, j);
        int rightPath = CountPathMazeWithI(n, m, i, j + 1);

        return downPath + rightPath;
    }



    static int CountPathMaze(int n, int m)
    {
        if(n ==1 || m ==1)
            return 1;

        return CountPathMaze(n -1, m) + CountPathMaze(n, m-1);

    }

    static void Permutation(string str, int index, string perString)
    {
        if(index == str.Length)
        {
            Console.WriteLine(perString);
            return;
        }

        for (int i = 0; i < str.Length; i++)
        {            
            char cur = str[i];

            string newStr = str.Substring(0, i) + str.Substring(i+1);
            Permutation(newStr, index, perString + cur);
        }
    }
}