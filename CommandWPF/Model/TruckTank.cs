using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandWPF.Model.Interface;

namespace CommandWPF.Model
{
    internal class TruckTank : ITank
    {
        public string Name => "Топливный бак КАМАЗ-5490";
        public decimal Price => 300000;
        public double Weight => 200;
        public double MaxVolume => 800;
    }
}
