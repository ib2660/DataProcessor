using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor.Transformations
{
    internal class MaxTransformation : ITransformation
    {
        public List<int> Transform(List<int> datapunkter)
        {
            List<int> result = [0];
            foreach (var item in datapunkter)
            {
                result[0] = Math.Max(result[0], item);
            }
            return result;
        }
        public override string ToString()
        {
            return "MaxTransformation";
        }
    }
}
