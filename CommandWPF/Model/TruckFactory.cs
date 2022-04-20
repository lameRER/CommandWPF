using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandWPF.Model.Interface;

namespace CommandWPF.Model
{
    internal class TruckFactory : IAutoFactory
    {
        public IBody CreateBody()
        {
            return new TruckBody();
        }

        public IEngine CreateEngine()
        {
            return new TruckEngine();
        }

        public ITank CreateTank()
        {
            return new TruckTank();
        }
    }
}
