using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapKurduCaseStudy.Model
{
     public class Rectangle: Shape
    {
        private readonly double _width;
        private readonly double _height;

         public Rectangle(double width, double height)
         {
             _width = width;
             _height = height;
         }

        public override double calculateArea()
        {
            return _height*_width;
        }

        public override double calculatePerimeter()
        {
            return 2*(_height+_width);
        }
    }
}
