using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandWPF.Model.Interface;

namespace CommandWPF.Model
{
    internal class CarBody : IBody
    {
        public double MaxWeight => 985;

        public string Name => "Кузов ВАЗ-1111";

        public decimal Price => 30000;

        public double Weight => 350;
    }
}
