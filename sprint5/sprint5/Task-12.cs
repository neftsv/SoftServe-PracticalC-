using System;
using System.Collections.Generic;
class Task2
{
    public static void SearchKeys(Dictionary<string, string> persons)
    {
        foreach (string key in persons.Keys)
        {
            Console.WriteLine(key);
        }
    }

    public static void SearchValues(Dictionary<string, string> person)
    {
        foreach (string value in person.Values)
        {
            Console.WriteLine(value);
        }
    }

    public static void SearchAdmin(Dictionary<string, string> persons)
    {
        foreach (var pers in persons)
        {
            if(pers.Value == "Admin") 
            {
                Console.WriteLine(pers.Key + " " + pers.Value);
                break;
            }
        }
    }
}