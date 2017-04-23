using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKurduCaseStudy.Model
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double calculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2),2);
        }

        public override double calculatePerimeter()
        {
            return Math.Round(2 * Math.PI * _radius,2);
        }
    }
}
