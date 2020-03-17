using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

            // TO Json
            // var obj = JsonConvert.DeserializeObject(json);
            // or
            // JObject obj = JObject.Parse(json);

            // To String    
            // result = JsonConvert.SerializeObject(json);

            JObject obj = JObject.Parse(json);
            
            var ModulePermission = obj["ModulePermission"];

            Console.WriteLine(ModulePermission);

            // 

            // foreach (var item in initJson) {
            //     Console.WriteLine(item);   
            //     // item.Value = item.Value.ToString().Replace("v1", "v2");                   
            // }

            // var jobj = JObject.Parse(json);       
            // foreach (var item in jobj.Properties()) {
            //     // item.Value = item.Value.ToString().Replace("v1", "v2");                   
            // }

            
            // Console.WriteLine(result);              
        }
        // File.WriteAllText(filepath, result);
    }
}
