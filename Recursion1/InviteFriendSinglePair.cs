
using System.Collections;
public class InviteFriendSinglePair
{
    public static void DrivingCode()
    {

        //Find the number of ways in which you can invite n people to your party, single  or in pairs

        Console.WriteLine("Place Tiles");
        int place = PlaceTiles(4, 2);
        Console.WriteLine(place);
        Console.WriteLine();

      int ans =   InviteFriend(4);

      Console.WriteLine(ans);

      //Print all the subsets of a set of first n natural numbers
        Console.WriteLine("Sub set");
        ArrayList set = new ArrayList();
        FindSubSet(2, set);
        //Console.WriteLine(Invites);
        Console.WriteLine();
    }

    static void FindSubSet(int n, ArrayList set)
    {
        if(n == 0)
        {
            PrintSet(set);
            return;
        }

        //add 
        set.Add(n);
        FindSubSet(n-1, set);

        //remove
        set.RemoveAt(set.Count -1);
        FindSubSet(n -1, set);
    }
    static int cout = 0;
    static void PrintSet(ArrayList set)
    {
        
        foreach (var item in set)
        {
            cout= cout +  Convert.ToInt32(item);    
            Console.Write(" " +item);
        }
        Console.WriteLine();
        //Console.Write(cout);
    }

    public static int PlaceTiles(int n, int m)
    {
        if(n == m)
        {
            return 2;
        }
        if(n <= m)
        {
            return 1;
        }

        int vertical = PlaceTiles(n - m, m);
        int horizontal = PlaceTiles(n - 1, m);

        return vertical + horizontal;
    }

    static int InviteFriend(int n)
    {
        if(n <= 1)
        {
            return 1; 
        }

        int single = InviteFriend(n -1);

        int pair = (n -1) * InviteFriend(n -2);

        return single + pair;
    }

}