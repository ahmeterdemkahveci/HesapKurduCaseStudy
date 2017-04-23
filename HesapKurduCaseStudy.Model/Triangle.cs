using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKurduCaseStudy.Model
{
    public class Triangle : Shape
    {
        private readonly double _adjacent;
        private readonly double _opposite;
        private readonly double _hypotenuse;

        public Triangle(double adjacent, double opposite, double hypotenuse)
        {
            _adjacent = adjacent;
            _opposite = opposite;
            _hypotenuse = hypotenuse;
        }

        public override double calculateArea()
        {
            return (_adjacent * _opposite) / 2;
        }

        public override double calculatePerimeter()
        {
            return _adjacent + _opposite + _hypotenuse;
        }
    }
}
