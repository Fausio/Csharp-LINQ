
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ.Models
{
    public class EscalarLastSingleFirst
    {
        public int[] empty = Enumerable.Empty<int>().ToArray();
        public int[] numbers = Enumerable.Range(0, 10).ToArray();
        public string[] Names = { "Fausio", "Luis", "Matsinhe", "João", "Ilda" };

        public int GetFist() =>
        numbers.FirstOrDefault(); // 0

        public int GetSingle() =>
        numbers.SingleOrDefault(s => s / 2 == 1); // 2

        public int GetLast() =>
        numbers.Last(last => last == 2); // 2

        public int GetElemetByIndex() =>
        Enumerable.Range(0, 5).ElementAt(3); // 2

    }
}