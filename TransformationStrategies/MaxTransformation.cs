namespace DataProcessor.TransformationStrategies;

internal class MaxTransformation : ITransformation
{
    public List<int> Transform(List<int> datapunkter)
    {
        return [datapunkter.Max()];
    }
}
