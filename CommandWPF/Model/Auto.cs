using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandWPF.Model.Interface;

namespace CommandWPF.Model
{
    internal class Auto
    {
        public IBody Body { get; }
        public IEngine Engine { get; }
        public ITank Tank { get; }

        public string Vin { get; }

        public Auto(IAutoFactory factory)
        {
            Body = factory.CreateBody();
            Engine = factory.CreateEngine();
            Tank = factory.CreateTank();
            Vin = Guid.NewGuid().ToString();
        }
    }
}
