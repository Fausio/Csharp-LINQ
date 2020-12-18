using System;
using LINQ.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ.Models
{
    public class EnumManipulator
    {
        public string JoinEnum<T>(IEnumerable<T> items) => string.Join(", ", items);
        public void Write<T>(IEnumerable<T> ToWrite) => Console.WriteLine(JoinEnum(ToWrite));

        public void Write<T>(string msg, IEnumerable<T> ToWrite) => Console.WriteLine(msg  + JoinEnum(ToWrite));
    }
}