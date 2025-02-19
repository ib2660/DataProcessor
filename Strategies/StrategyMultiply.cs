namespace DataProcessor.Strategies;

internal class StrategyMultiply : IStrategy
{
    public int ProcessData(int datapunkt)
    {
        return datapunkt* 2;
    }

    public override string ToString()
    {
        return "StrategyMultiply";
    }
}
