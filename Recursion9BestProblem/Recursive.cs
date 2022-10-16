

public class Recursive
{
    public static void DrivingCode()
    {
        //Remove all duplicates in String
        Console.WriteLine("Remove dup");
        string str = "sasdafg";
        RemoveDup(str, 0, "");
        Console.WriteLine();


        //Print all subsequences
        Console.WriteLine("Print all subsequences");
        string str1 = "abc";
        PrintAllSubSequences(str1, 0, "");
        Console.WriteLine();
        // Print all unique subsequences

        Console.WriteLine("Print all subsequences");
        string str2 = "aaa";
        HashSet<string> set = new HashSet<string>();
        PrintAllSubSequencesSet(str2, 0, "", set);


    }
    static void PrintAllSubSequencesSet(string str, int index, string newStr, HashSet<string> set)
    {
        if(index == str.Length)
        {
            if(set.Contains(newStr))
            {
                return;
            }
            else
            {            
                Console.WriteLine(newStr);
                set.Add(newStr);
                return;            
            }
            //return;
        }
        
        char curr = str[index];

        PrintAllSubSequencesSet(str, index + 1, newStr + curr, set);
        PrintAllSubSequencesSet(str, index + 1, newStr, set);
    }

    static void PrintAllSubSequences(string str, int index, string newStr)
    {
        if(index == str.Length)
        {
            Console.WriteLine(newStr);
            return;    
        }
        
        char curr = str[index];
        //Console.WriteLine(" char - " +curr);
        
        //newStr += curr;
        PrintAllSubSequences(str, index + 1, newStr + curr);
        //Console.WriteLine(newStr );
        PrintAllSubSequences(str, index + 1, newStr);

    }

    static bool[] arrBool = new bool[26];
    static void RemoveDup(string str, int index, string newStr)
    {
        
        if(index == str.Length -1)
        {
            Console.Write(newStr);
            return;
        }
        
        char cur = str[index];
        //Console.WriteLine(cur);
        //Console.WriteLine(arrBool[cur - 'a']);
        if(!arrBool[cur - 'a'])
        {
            newStr += cur;
            arrBool[cur - 'a'] = true;
        }
        

        RemoveDup(str, index + 1, newStr);

    }
}