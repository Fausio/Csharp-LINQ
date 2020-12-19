using System.Linq;
using System;
using System.Collections.Generic;

namespace LINQ.Models
{
    public class Ordering
    {
        ObjectClassPopulated models = new ObjectClassPopulated();
        EnumManipulator manipulator = new EnumManipulator();

        public void Order()
        {

            var item = models.MyData.OrderByDescending(x => x.Number);
            Console.Write("OrderByDescending: " + string.Join(", ",item.Select( y => $"{y.Number} : {y.Text}")));
       
            Console.Write( ", \n"+"OrderByDescending Reverse: " + string.Join(", ",item.Reverse().Select( y => $"{y.Number} : {y.Text}")));
 

        }

    }
}