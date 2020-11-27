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
                Syntax clss = new Syntax(); 
                //result = result.Select(x => x.ToLower());

                // string.Join => join the list 
              Console.WriteLine(string.Join(", ",clss.FluentType));  
             
       }
    }


     
}

