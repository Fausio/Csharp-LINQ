using System;
using LINQ.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ.Models
{
    public class Filtering
    {
        public EnumManipulator manipulator = new EnumManipulator();
        public ObjectClassPopulated Mymodels = new ObjectClassPopulated();

        public void FilteringWhere()
        {
            IEnumerable<int> filter = Mymodels.MyData.Where(m => m.Number % 2 == 0).Select(m => m.Number);
            manipulator.Write(filter);
        }

/*         public void FilteringTakeUntilWhile()
        {
            IEnumerable<int> filter = Mymodels.MyData.TakeWhile(m => m.Number > 5).Select(m => m.Number);
            manipulator.Write(filter);
        } */
    }
}