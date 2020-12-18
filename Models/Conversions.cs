using System.Linq;

namespace LINQ.Models
{
    public class Conversions
    {
        // conversion (import and export)
        // convert the collection to  another velues

        public ObjectClassPopulated Mymodels = new ObjectClassPopulated();
        public EnumManipulator manipulator = new EnumManipulator();

        public void _Conversions()
        {
            object[] importExport = Mymodels.MyData.Cast<object>().ToArray();

            var dicionary = Mymodels.MyData.ToDictionary(key => key.Number, value => value.Text);
            manipulator.Write("dicionary :", dicionary.Select(kvp => $"{kvp.Key}:{kvp.Value}"));
        }

    }
}