
public class PermutationString
{
    public static void DrivingCode()
    {

        string str = "abc";
        StringPermutation(str, "");
        Console.WriteLine();
        //Count total path in a maze to move from (0,0) to (n,m)
        //
        Console.WriteLine("Maze --------Path");
        int totalPath = MazeTotalPath(0,0, 3, 3);
        Console.WriteLine(totalPath);
        Console.WriteLine();

        //Count total path in a maze to move from (0,0) to (n,m)
        Console.WriteLine("Total ways");
        int totalPath1 = TotalPathInMaze(0, 0, 3, 3);
        Console.WriteLine(totalPath1);
        Console.WriteLine();

        // Place Tiles of Size 1 x m  in the floor of Size n x m

        Console.WriteLine("Place Tiles");
        int ans1 = PlaceTiles(4, 2);
        Console.WriteLine(ans1);
        Console.WriteLine();
    }

    static int PlaceTiles(int n, int m)
    {
        if(n ==m)
            return 2;
        
        if(n <= m)
            return 1;

        int vertical = PlaceTiles(n -m, m);
        int horizontal = PlaceTiles(n-1, m);

        return horizontal + vertical ;
    }

    static int TotalPathInMaze(int i, int j, int n, int m)
    {
        if(i == n || j == m)
        {
            return 0;
        }
        if(i == n -1 && j == m -1)
        {
            return 1;
        }

        int rightPath = TotalPathInMaze(i+1, j, n, m);

        int downPath = TotalPathInMaze(i, j+1, n, m);

        return rightPath + downPath ;
    }
    static int MazeTotalPath(int i, int j, int n, int m)
    {
        if(n == i || m == j)
        {
            return 0;
        }

        if(n == i + 1 && m == j + 1)
        {
            return 1;
        }

        int downPath = MazeTotalPath(i+1, j, n, m);

        int rightPath = MazeTotalPath(i, j+1, n, m);

        return downPath + rightPath;
    }

    static void StringPermutation(string str, string perString)
    {
        if(str.Length == 0)
        {
            Console.WriteLine(perString);
            return;
        }

        for (int i = 0; i < str.Length; i++)
        {
            char cur = str[i];

            string substring = str.Substring(0, i) + str.Substring(i + 1);

            StringPermutation(substring, perString + cur);
        }
    }
}