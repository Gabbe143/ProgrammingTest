using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREA_SAKER
{
    class Circle : Shape
    {
        public double Radius;

        public override double GetArea()
        {
            return (Radius * Radius * Math.PI);
        }
        public override double GetCircumference()
        {
            return (2 * Radius * Math.PI);
        }
    }
}
