using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREA_SAKER
{
    class Square : Shape
    {
        public double Side;

        public override double GetArea()
        {
            return Side*Side;
        }
        public override double GetCircumference()
        {
            return 4*Side;
        }
    }
}
