using System;
using LINQ.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ.Models
{
    public class Filtering
    {
        public List<ObjectClass> MyData = new List<ObjectClass>();

        public void populateDate()
        {
            foreach (int item in Enumerable.Range(0,10))
            {
              MyData.Add(new ObjectClass(){ Number = item});
            }
        }
    }
}