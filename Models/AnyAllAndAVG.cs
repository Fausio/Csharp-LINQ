using System.Collections;
using System.Linq;

namespace LINQ.Models
{
    public class AnyAllAndAVG
    {

        public string[] Names = { "Fausio", "Luis", "Matsinhe", "João", "Ilda" };

        public bool GetAnyResult() =>
        Names.Any(x => x.StartsWith("F"));

        public bool GetAllResult() =>
        Names.All(x => x.StartsWith("F"));
 
    }
}