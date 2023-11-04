using System;
using System.Collections.Generic;
using System.Linq;

class Task22
{
    public static ILookup<string, string> CreateNotebook(Dictionary<string, string> phonesToNames)
    {
        Lookup<string, string> lookup = (Lookup<string, string>)phonesToNames
            .Where(kv => !string.IsNullOrEmpty(kv.Value))
            .ToLookup(kv => kv.Value ?? string.Empty, kv => kv.Key);

       // Lookup<string, string> l = (Lookup<string, string>)lookup;
        return lookup;
    }
}