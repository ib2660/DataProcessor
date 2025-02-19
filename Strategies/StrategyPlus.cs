namespace DataProcessor.Strategies;

internal class StrategyPlus : IStrategy
{
    public int ProcessData(int datapunkt)
    {
        return datapunkt + 1;
    }

    public override string ToString()
    {
        return "StrategyPlus";
    }
}
