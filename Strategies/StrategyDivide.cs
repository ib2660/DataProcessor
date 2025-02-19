namespace DataProcessor.Strategies;

internal class StrategyDivide:IStrategy
{
    public int ProcessData(int datapunkt)
    {
        return datapunkt / 2;
    }

    public override string ToString()
    {
        return "StrategyDivide";
    }
}
