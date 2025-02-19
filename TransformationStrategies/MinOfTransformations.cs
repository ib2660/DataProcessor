namespace DataProcessor.TransformationStrategies;

internal class MinOfTransformations : ITransformation
{
    public List<int> Transform(List<int> datapunkter)
    {
        return [datapunkter.Min()];
    }
}
