
public class ArraySheet2
{
    public static void DrivingCode()
    {
        string s = "Geeks";
        int n = s.Length;
        string ans = ReverseString(s);
        Console.WriteLine(ans);

        Console.WriteLine(" ---------- ");

       string ans1 = ReverseStringRecur(s, s.Length-1);
        Console.WriteLine(ans1);

    }
    static string empty = "";
    static string ReverseStringRecur(string str, int index)
    {
        
        if(index == 0)
        {
            return empty += str[index];
            //Console.Write(" " + str[index]);
            //return;
        }
        
        //char curChar = str[index];
        empty += str[index];
        //Console.Write(" " + str[index]);
        return ReverseStringRecur(str, index -1); 
    }



    static string ReverseString(string s)
    {
        // for(int i =0; i < s.Length; i++)
        // {
        //     Console.Write(" " + s[i]);
        // }
        
        string empty = "";

        Console.WriteLine();
        for(int i =s.Length-1; i >= 0 ; i--)
        {
            //empty += s[i];
        }
        
        
        Console.WriteLine();

        int start = 0;
        int end = s.Length-1;

        while(start <= end)
        {
            //Console.Write(" " + s[end]);
            // += s[end];
            end--;
        }
        //return empty;

        Console.WriteLine();
        int n = s.Length;
        for (int i = 0; i < n; i++)
        {            
            //Console.Write(" " + s[n - 1 - i]);
            //s[i] = s[n - 1 - i]; 
            //s[n -1 - i] = temp;
            empty += s[n -1 -i];
        }
        return empty;
        //Console.WriteLine(s);


    }
}