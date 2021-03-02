using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREA_SAKER
{
    class Rectangle : Shape
    {
        public double Length;
        public double Width;

        public override double GetArea()
        {
            return (Length * Width);
        }
        public override double GetCircumference()
        {
            return (2 * Length) + (2 * Width);
        }
    }
}
