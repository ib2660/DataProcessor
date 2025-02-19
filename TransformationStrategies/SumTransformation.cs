namespace DataProcessor.TransformationStrategies;

internal class SumTransformation : ITransformation
{
    public List<int> Transform(List<int> datapunkter)
    {
        return [datapunkter.Sum()];
    }
}
