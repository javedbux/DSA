
public class IteratorPrac
{
    public static void DrivingCode()
    {
        HashMapDistionary();
    }

   static void HashMapDistionary()
   {
        //
        Dictionary<string, int> map = new Dictionary<string, int>();
        map.Add("India", 123);
        map.Add("China", 231);
        map.Add("USA", 156);

        //Console.WriteLine(map);
        foreach (var item in map)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Total key/value pairs"+
              " in myDict are : " + map.Count);
        

        //try get value from dictionary
        int val = 0;
        if(map.TryGetValue("China", out val))
        {
            Console.WriteLine("Val = " + val);

            Console.WriteLine(map["China"]);
        }

        //check the value
        if(map.ContainsKey("War"))
        {
            Console.WriteLine("Already value exit ");
        }
        else
        {
            map["War"] = 12345342;
        }

        //update the values
        map["China"] = 231111;
        // add new 
        map["Hgt"] =  786;

        //Remove any item
        map.Remove("USA");



        Console.WriteLine();
        foreach (KeyValuePair<string, int> pair in map)
        {
            Console.WriteLine(pair.Key + " -" + pair.Value);
        }

        int[] arr = {2,3,1,5,6,7};
        
        foreach (KeyValuePair<string, int> pair in map)
        {
            Console.WriteLine("Key : " + pair.Key + " - Value : " + pair.Value);
        }

        //clear all the item in map
        map.Clear();
        Console.WriteLine("Total key/value pairs"+
              " in myDict are : " + map.Count);

   }
}