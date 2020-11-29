using System.Collections.Generic;

namespace LINQ.Models
{
    public class ObjectClass
    {
        public int Number   { get; set; }
         public string Text { get; set; }
          public List<string> TextList { get; set; }

        public override string ToString()
        {
            return Text;
        }

        
    }
}