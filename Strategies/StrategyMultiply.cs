namespace DataProcessor.Strategies;

internal class StrategyMultiply : IStrategy
{
    public List<int> ProcessData(List<int> datapunkter)
    {
        List<int> result = [];
        foreach (int datapunkt in datapunkter)
        {
            result.Add(datapunkt * 2);
        }
        return result;
    }

    public override string ToString()
    {
        return "StrategyMultiply";
    }
}
