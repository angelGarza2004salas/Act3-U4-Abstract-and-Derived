using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_and_derived.Act3_U4
{
    public class Square : Figure
    {
        public double Lado { get; set; }

        public Square(double lado)
        {
            Lado = lado;
        }

        public override double CalculateArea()
        {
            return Lado * Lado;
        }
    }
}
