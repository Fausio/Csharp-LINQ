using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ.Models
{
    public static class Start
    {
        public static List<string> Names = new List<string>() { "Fausio", "Luis", "Matsinhe", "João", "Ilda" };

        public static void Run()
        {
            /* FistQuery(); */
        }

       /*  public static void FistQuery()
        {
            IEnumerable<string> result = System.Linq.Enumerable.Where(Names, x => x.Length == 4);
            Console.WriteLine(string.Join(",", result));
        } */

        public static IEnumerable<string> FistQueryResult(){

            return  Enumerable.Where(Names, x => x.Length == 4)
                              .Select(x => x.ToLower());
        }
        
         
    }
}