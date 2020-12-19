using System.Collections.Generic;
using System.Linq;

namespace LINQ.Models
{
    public class Zip
    {
        public int[] numers = { 1, 25, 3, 45 };
        public string[] letters = { "Fausio", "Luis", "Matsinhe" };

        public void ziper()
        {
            var zipped = numers.Zip(letters, (n, l) => $"{n} : {l}");
            System.Console.Write(string.Join(", ",zipped));
        }
    }
}