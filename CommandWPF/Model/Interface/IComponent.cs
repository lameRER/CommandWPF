﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWPF.Model.Interface
{
    internal interface IComponent
    {
        string Name { get; }
        decimal Price { get; }
        double Weight { get; }
    }
}
