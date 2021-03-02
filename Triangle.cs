using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREA_SAKER
{
    class Triangle : Shape
    {
        public double Height;
        public double Base;
        public double Side_a;
        public double Side_b;
        public double Side_c;

        public override double GetArea()
        {
            return (Height * Base)/2;
        }
        public override double GetCircumference()
        {
            return Side_a + Side_b + Side_c;
        }
    }
}
