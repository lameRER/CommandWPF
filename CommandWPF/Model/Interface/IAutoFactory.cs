using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWPF.Model.Interface
{
    internal interface IAutoFactory
    {
        IBody CreateBody();
        IEngine CreateEngine();
        ITank CreateTank();
    }
}
