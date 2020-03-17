using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Program
{
    static public void Main()
    {
        Console.WriteLine("ようこそ");


        string filepath = "./data/mp.json";
        string result = string.Empty;
        using (StreamReader r = new StreamReader(filepath))
        {
            var json = r.ReadToEnd();
            // var jobj = JObject.Parse(json);       
            // foreach (var item in jobj.Properties()) {
            //     // item.Value = item.Value.ToString().Replace("v1", "v2");                   
            // }
            result = JsonConvert.SerializeObject(json);
            Console.WriteLine(result);              
        }
        // File.WriteAllText(filepath, result);
    }
}
