namespace DataProcessor.Strategies;

internal class StrategyPlus : IStrategy
{
    public List<int> ProcessData(List<int> datapunkter)
    {
        List<int> result = [];
        foreach (int datapunkt in datapunkter)
        {
            result.Add(datapunkt + 1);
        }
        return result;
    }

    public override string ToString()
    {
        return "StrategyPlus";
    }
}
