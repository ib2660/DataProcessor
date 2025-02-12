using DataProcessor;
using DataProcessor.Strategies;
using System.Text;

string jsonString = File.ReadAllText("jsconfig.json");

DataProcesser dataProcessor = new(new StrategyMinus(), jsonString);
Console.WriteLine(dataProcessor.Strategy.ToString());
Console.WriteLine(dataProcessor.ProcessData().MakeString());
StaticMethods.PrintTransformation(dataProcessor);
Console.WriteLine("-----");
dataProcessor.SetStrategy(new StrategyPlus());
Console.WriteLine(dataProcessor.Strategy.ToString()); 
Console.WriteLine(dataProcessor.ProcessData().MakeString());
StaticMethods.PrintTransformation(dataProcessor);
Console.WriteLine("-----"); 
dataProcessor.SetStrategy(new StrategyMultiply());
Console.WriteLine(dataProcessor.Strategy.ToString()); 
Console.WriteLine(dataProcessor.ProcessData().MakeString());
StaticMethods.PrintTransformation(dataProcessor);
Console.WriteLine("-----"); 
dataProcessor.SetStrategy(new StrategyDivide());
Console.WriteLine(dataProcessor.Strategy.ToString()); 
Console.WriteLine(dataProcessor.ProcessData().MakeString());
StaticMethods.PrintTransformation(dataProcessor);
Console.WriteLine("-----"); 
dataProcessor.SetStrategy(new StrategySquare());
Console.WriteLine(dataProcessor.Strategy.ToString()); 
Console.WriteLine(dataProcessor.ProcessData().MakeString());
StaticMethods.PrintTransformation(dataProcessor);
Console.WriteLine("-----"); 
dataProcessor.SetStrategy(new StrategyMinus());
Console.WriteLine(dataProcessor.Strategy.ToString()); 
Console.WriteLine(dataProcessor.ProcessData().MakeString());
StaticMethods.PrintTransformation(dataProcessor);

internal static class StaticMethods
{
    internal static string MakeString<T>(this List<T> list)
    {
        if (list.Count == 0) return "";
        if (list.Count == 1) return list[0]!.ToString()!;
        StringBuilder sb = new();
        foreach (var item in list)
        {
            sb.Append(item!.ToString());
            sb.Append(", ");
        }
        return sb.ToString();
    }

    internal static void PrintTransformation(DataProcesser dataProcessor)
    {
        foreach (var transformation in dataProcessor.Transformations)
        {
            Console.WriteLine(transformation.ToString());
            foreach (var item in transformation.Transform(dataProcessor.ProcessData()))
            {
                Console.WriteLine(item);
            }
        }
    }
}