using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_and_derived.Act3_U4
{
    public class Circle : Figure
    {
        public double Radio { get; set; }

        public Circle(double radio)
        {
            Radio = radio;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
