namespace DataProcessor.Strategies;

internal class StrategySquare : IStrategy
{
    public int ProcessData(int datapunkt)
    {
        return datapunkt * datapunkt;
    }

    public override string ToString()
    {
        return "StrategySquare";
    }
}
