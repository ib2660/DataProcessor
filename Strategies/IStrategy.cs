namespace DataProcessor.Strategies;

internal interface IStrategy
{
    int ProcessData(int datapunkt);
    string ToString();
}