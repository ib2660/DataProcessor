namespace DataProcessor.Strategies;

internal class StrategySquare : IStrategy
{
    public List<int> ProcessData(List<int> datapunkter)
    {
        List<int> result = [];
        foreach (int datapunkt in datapunkter)
        {
            result.Add(datapunkt * datapunkt);
        }
        return result;
    }

    public override string ToString()
    {
        return "StrategySquare";
    }
}
