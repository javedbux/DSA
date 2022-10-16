
using System.Collections;

public class MazeCount
{
    public static void DrivingCode()
    {

      int ans =  CountPathMaze(3, 3, 0,0);
      Console.WriteLine(ans);
        Console.WriteLine();
    
        Console.WriteLine("Maze Prac");
      int ans1 =  CountPathMazePrac(3, 3 , 0,0);
      Console.WriteLine(ans1);

      //Tiling problem
        Console.WriteLine("Tiling problem");
      int ans2 =  TilingProblem(4, 2);
      Console.WriteLine(ans2);

        //Friends pairing problem
        Console.WriteLine("Friends pairing problem");

        int ans3 = FriendsPairing(4);
        Console.WriteLine(ans3);

        Console.WriteLine();
        Console.WriteLine("Subsets of a set");
        ArrayList set = new ArrayList();
        SubsetsOfASet(3 , set);


    }
    static void PrintSet(ArrayList set)
    {
        foreach (var item in set)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine();
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


        //Remove hoga
        set.RemoveAt(set.Count - 1);
        // nahi hoga
        SubsetsOfASet(n -1, set);
    }



    static int FriendsPairing(int n)
    {
        //1 2 3 .  1  23 . 2 13 . 3 12.  3!

        if(n <=1)
            return 1;
        // if(n ==0)
        //     return 1;

        int single = FriendsPairing(n -1);
        int pair = (n-1) * FriendsPairing(n - 2);

        return single + pair;
    }



    static int TilingProblem(int n, int m)
    {
        if(n == m)
        {
            //Console.WriteLine("n = " + n + " m = " + m);
            return 2;
        }
        if(n <= m)
        {
            //Console.WriteLine("n = " + n + " m = " + m);
            return 1;
        }

        int horizontal = TilingProblem(n - m, m);
        int vertical = TilingProblem(n -1, m );

        return horizontal + vertical ;
    }


    static int CountPathMazePrac(int n, int m,int i,int j)
    {
        if( i == n || j == m)
            return 0;
        
        if(i == n - 1 && j == m -1)
            return 1;

        int down = CountPathMazePrac(n, m, i+1, j);
        int right = CountPathMazePrac(n, m, i, j+1);

        return down + right;
    } 

    static int CountPathMaze(int n, int m, int i, int j)
    {
        if( i == n || j == m)
        {
            //Console.WriteLine("OR");
            return 0;
        }
        if(i == n - 1 && j == m - 1)
        {
            //Console.WriteLine("And");
            return 1;
        }
            
        int downPath = CountPathMaze(n, m, i +1, j);
        int rightPath = CountPathMaze(n, m , i , j+1);

        return downPath + rightPath ; 

    }
}