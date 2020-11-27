using System;
using LINQ.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ.Models
{
    public class Syntax
    {
        public static List<string> Names = new List<string>() { "Fausio", "Luis", "Matsinhe", "João", "Ilda" };

        public IEnumerable<string> FluentType() =>
        Names.Where(x => x.Contains("i"))
             .OrderBy(x => x.Length)
             .Select(x => x.ToUpper());

        public IEnumerable<string> QueryType() =>
        from x in Names
        where x.Contains("i")
        orderby x.Length
        select x.ToUpper();

        public int FluentType_And_QueryType() =>
        (
            from x in Names
            where x.Contains("i")
            orderby x.Length
            select x.ToUpper()
        )
        .Count();


    }
}