using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataProcessor.Transformations
{
    internal class SumTransformation : ITransformation
    {
        public List<int> Transform(List<int> datapunkter)
        {
            List<int> result = [0];
            foreach (var item in datapunkter)
            {
                result[0] += item;
            }
            return result;
        }

        public override string ToString()
        {
            return "SumTransformation";
        }
    }
}
