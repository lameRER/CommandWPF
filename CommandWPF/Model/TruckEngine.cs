using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandWPF.Model.Interface;

namespace CommandWPF.Model
{
    internal class TruckEngine : IEngine
    {
        public string Name => "Daimler OM 457LA";
        public decimal Price => 2000000;
        public double Weight => 150;
        public double MaxSpeed => 110;
    }
}
