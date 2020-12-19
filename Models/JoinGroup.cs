using System;
using LINQ.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ.Models
{
    public class JoinGroup
    {
        public ObjectClassPopulated models = new ObjectClassPopulated();
        public IEnumerable<int> ListOne = Enumerable.Range(0, 11);// 0..10
        public IEnumerable<int> LIstTwo = Enumerable.Range(5, 6); // 5 - 10

        public void JoinMethot()
        {

            /* from p in Parent
            join c in Child on p.Id equals c.Id into g
            select new { Parent = p, Children = g } */

            var query = from i in models.MyData
                        join j in LIstTwo on i.Number equals j
                        
                        select i;
            foreach (var i in query)
            {
                /* if (i.Any())
                {
                    Console.WriteLine("empty"); */
                 
                        Console.WriteLine($"{i.Number} : {i.Text}");
                   
 

            }

        }
    }
}