using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandWPF.Model.Interface;

namespace CommandWPF.Model
{
    internal class TruckBody : IBody
    {
        public double MaxWeight => 7900;
        public string Name => "Кузов КАМАЗ-5490";
        public decimal Price => 1500000;
        public double Weight => 1000;
    }
}
