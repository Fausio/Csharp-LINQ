using System; 
using LINQ.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
 
            IEnumerable<string> result = Start.FistQueryResult();
                //result = result.Select(x => x.ToLower());

                // string.Join => join the list 
              Console.WriteLine(string.Join(", ",result ));  
             
       }
    }


     
}

