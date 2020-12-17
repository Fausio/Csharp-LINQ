using System;
using LINQ.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


public class checkers
{

    public static List<string> Names = new List<string>() { "Fausio", "Luis", "Matsinhe", "João", "Ilda" };
    public int[] numbers = Enumerable.Range(0, 10).ToArray();

 
    //-------------------------- 
    bool ischeckContains = Names.Contains("João");
    bool ischeckAll = Names.All(x => x.StartsWith('F'));
    bool ischeckAny = Names.Any(x => x.StartsWith('F'));
}
