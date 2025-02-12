using DataProcessor.Strategies;
using DataProcessor.Transformations;
using System.Text.Json;

namespace DataProcessor
{
    internal class DataProcesser
    {
        List<int> datapunkter = [];
        public List<int> Datapunkter { get { return datapunkter; } private set { datapunkter = value; } }
        List<ITransformation> transformations = [];
        public List<ITransformation> Transformations { get { return transformations; } private set { transformations = value; } }
        internal IStrategy Strategy { get; private set; }

        internal DataProcesser(IStrategy strategy, string jsonstring)
        {
            Strategy = strategy;
            if (!SetData(jsonstring)) Console.WriteLine("instanciation failed");
        }

        internal void SetStrategy(IStrategy strategy)
        {
            Strategy = strategy;
        }

        private bool SetData(string jsonString)
        {
            var config = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonString);
            if (config == null) return false;
            datapunkter = JsonSerializer.Deserialize<List<int>>(config["datapunkter"].ToString())!;
            if (datapunkter.Count == 0) return false;
            var transformationsList = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(config["transformations"].ToString());
            if (transformationsList!.Count == 0) return false;
            foreach (var transformation in transformationsList)
            {
                var typeName = transformation["Type"];
                var type = Type.GetType(typeName);
                if (type == null || !typeof(ITransformation).IsAssignableFrom(type))
                {
                    return false;
                }
                var transformationInstance = (ITransformation)Activator.CreateInstance(type)!;
                if (transformationInstance == null) return false;
                transformations.Add(transformationInstance);
            }
            return true;
        }

        internal List<int> ProcessData()
        {
            List<int> result;
            result = Strategy.ProcessData(datapunkter);
            return result;
        }
    }
}
