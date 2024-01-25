
namespace ProgTechniques.ListFilter
{
    internal class GenericValues<T>
    {
        public static List<T> GenerateList(params T[] values)
        {
            return new List<T>(values);
        }
    }
}
