﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor.Transformations
{
    internal interface ITransformation
    {
        List<int> Transform(List<int> datapunkter);
        string ToString();
    }
}
