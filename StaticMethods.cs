using DataProcessor;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;

internal static class StaticMethods
{
    internal static string MakeString<T>(this List<T> list)
    {
        if (list.Count == 0) return "";
        if (list.Count == 1) return list[0]!.ToString()!;
        StringBuilder sb = new();
        foreach (var item in list)
        {
            sb.Append(item!.ToString());
            sb.Append(", ");
        }
        sb.Append("\n");
        return sb.ToString();
    }

    internal static string ListsString<T>(this List<List<T>> lists)
    {
        if (lists.Count == 0) return "";
        if (lists.Count == 1) return lists[0]!.MakeString();
        StringBuilder sb = new();
        foreach (var list in lists)
        {
            sb.Append(list!.MakeString());
            sb.Append(", ");
        }
        return sb.ToString();
    }
}