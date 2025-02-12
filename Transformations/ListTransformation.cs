namespace DataProcessor.Transformations
{
    internal class ListTransformation : ITransformation
    {
        public List<int> Transform(List<int> datapunkter)
        {
            return datapunkter;
        }

        public override string ToString()
        {
            return "ListTransformation";
        }
    }
}
