namespace DataProcessor.Strategies;

internal interface IStrategy
{
    List<int> ProcessData(List<int> datapunkter);

    string ToString();
}