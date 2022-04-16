using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandWPF.Model.Interface;

namespace CommandWPF.Model
{
    internal class CarFactory : IAutoFactory
    {
        public IBody CreateBody()
        {
            return new CarBody();
        }

        public IEngine CreateEngine()
        {
            return new CarEngine();
        }

        public ITank CreateTank()
        {
            return new CarTank();
        }
    }
}
