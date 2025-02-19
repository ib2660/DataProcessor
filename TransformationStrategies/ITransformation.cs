namespace DataProcessor.TransformationStrategies;

internal interface ITransformation
{
    List<int> Transform(List<int> datapunkter);
}
