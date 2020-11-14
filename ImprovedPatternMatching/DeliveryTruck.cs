using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedPatternMatching
{
    public class DeliveryTruck
    {
        public int GrossWeightClass { get; set; }

        public int Passangers { get; set; }

        public void Deconstruct(out int grossWeightClass, out int passangers) => (grossWeightClass, passangers) = (this.GrossWeightClass, this.Passangers);
    }
}
