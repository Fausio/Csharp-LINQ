using System.Collections.Generic;

namespace LINQ.Models
{
    public class ObjectClass
    {
        public int Number { get; set; }
        public string Text { get; set; }
        public List<string> TextList = new List<string>()
        {
              "Beneficiarios que ",
              "fazem parte de ",
              "Grupo de Apoio de Adoescentes"
        };

        public override string ToString()
        {
            return Text;
        }


    }
}