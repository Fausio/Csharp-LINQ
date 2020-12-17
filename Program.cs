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
             var a = Enumerable.Range(10,8);
            System.Console.WriteLine(string.Join(", ",a));

        }
    }
}
