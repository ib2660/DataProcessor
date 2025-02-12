namespace DataProcessor.Transformations;

internal class MinOfTransformations : ITransformation
{
    public List<int> Transform(List<int> datapunkter)
    {
        List<int> result = [int.MaxValue];
        foreach (var item in datapunkter)
        {
            result[0] = Math.Min(result[0], item);
        }
        return result;
    }

    public override string ToString()
    {
        return "MinOfTransformations";
    }
}
