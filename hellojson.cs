/*
 this program expects a serialized JSON string from the user like this
 { 'Name': 'Joe Rodriguez', 'Address': { 'City': 'New York', 'State': 'NY' }, 'Age': 38 }
*/

using System;
using Newtonsoft.Json;
 class hellojson
    {
   public static void Main()
    {
      Console.WriteLine("Enter JSON to be deserialized\t\t");
      dynamic json_input = Convert.ToString(Console.ReadLine());
      dynamic stuff = GetJson(json_input);
      Console.WriteLine(stuff.Name);
      Console.WriteLine(stuff.Address.City);
    }

    public static dynamic GetJson(dynamic input)
    {
      return JsonConvert.DeserializeObject(input);
    }
  }
