using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandWPF.Model.Interface;

namespace CommandWPF.Model
{
    internal class CarTank : ITank
    {
        public string Name => "Топливный бак ВАЗ-1111";
        public decimal Price => 20000;
        public double Weight => 45;
        public double MaxVolume => 30;
    }
}
