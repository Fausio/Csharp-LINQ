using System;
using LINQ.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ.Models
{
    public class ObjectClassPopulated
    {
        public List<ObjectClass> MyData = new List<ObjectClass>();

        public ObjectClassPopulated()
        {
            foreach (int item in Enumerable.Range(0, 10)) // 0 - 9
            {
                MyData.Add(new ObjectClass() { Number = item });
            }
        }
    }
}