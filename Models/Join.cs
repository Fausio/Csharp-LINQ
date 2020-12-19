using System;
using LINQ.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ.Models
{
    public class Join
    {
        public IEnumerable<int> ListOne = Enumerable.Range(0, 11);// 0..10
        public IEnumerable<int> LIstTwo = Enumerable.Range(5, 6); // 5 - 10

        public void JoinMethot()
        {

            IEnumerable<int> query = from i in ListOne
                                     join jj in LIstTwo on i equals jj
                                     select i;

            Console.WriteLine(string.Join(" ,", query));
        }

    }
}