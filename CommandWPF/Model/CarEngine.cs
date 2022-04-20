using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandWPF.Model.Interface;

namespace CommandWPF.Model
{
    internal class CarEngine : IEngine
    {
        public double MaxSpeed => 80;
        public string Name => "Двигатель ВАЗ-1111";
        public decimal Price => 5000;
        public double Weight => 250;
    }
}
