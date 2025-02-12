using DataProcessor.Strategies;

internal class StrategyMinus : IStrategy
{
    public List<int> ProcessData(List<int> datapunkter)
    {
        List<int> result = [];
        foreach (int datapunkt in datapunkter)
        {
            result.Add(datapunkt - 1);
        }
        return result;
    }

    public override string ToString()
    {
        return "StrategyMinus";
    }
}