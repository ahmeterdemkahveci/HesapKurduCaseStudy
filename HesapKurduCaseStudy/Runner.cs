using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HesapKurduCaseStudy.Model;

namespace HesapKurduCaseStudy
{
    public class Runner
    {
        public const String CIRCLE = "circle";
        public const String TRIANGLE = "triangle";
        public const String RECTANGLE = "rectangle";
        public const String VALIDATION_MESSAGE = "Please enter a value which is valid and greater than 0";


        public void Run()
        {
            string shape = shapeInputValidation();

            switch (shape)
            {
                case HesapKurduCaseStudy.Runner.CIRCLE:
                    string radiusStr;
                    double radius;
                    Console.WriteLine("Input the length of Radius");
                    radiusStr = Console.ReadLine();
                    Double.TryParse(radiusStr, out radius);
                    while (radius <= 0)
                    {
                        Console.WriteLine(HesapKurduCaseStudy.Runner.VALIDATION_MESSAGE);
                        radiusStr = Console.ReadLine();
                        Double.TryParse(radiusStr, out radius);
                    }
                    createShapes(shape, radius, 0, 0);
                    break;
                case HesapKurduCaseStudy.Runner.TRIANGLE:
                    bool triangle = false;
                    while (!triangle)
                    {
                        triangle = triangleChecker(shape, triangle);
                    }
                    break;
                case HesapKurduCaseStudy.Runner.RECTANGLE:
                    string heightStr, widthStr;
                    double height, width;
                    Console.WriteLine("Input the length of Height");
                    heightStr = Console.ReadLine();
                    Double.TryParse(heightStr, out height);
                    while (height <= 0)
                    {
                        Console.WriteLine(HesapKurduCaseStudy.Runner.VALIDATION_MESSAGE);
                        heightStr = Console.ReadLine();
                        Double.TryParse(heightStr, out height);
                    }
                    Console.WriteLine("Input the length of Width");
                    widthStr = Console.ReadLine();
                    Double.TryParse(widthStr, out width);
                    while (width <= 0)
                    {
                        Console.WriteLine(HesapKurduCaseStudy.Runner.VALIDATION_MESSAGE);
                        widthStr = Console.ReadLine();
                        Double.TryParse(widthStr, out width);
                    }
                    createShapes(shape, 0, height, width);
                    break;
                default:
                    break;
            }
        }
        private string shapeInputValidation()
        {
            Console.WriteLine("Input the name of your shape");
            string shape = Console.ReadLine();
            shape = shape.ToLower();
            while (!shape.Equals(HesapKurduCaseStudy.Runner.CIRCLE) && !shape.Equals(HesapKurduCaseStudy.Runner.TRIANGLE) && !shape.Equals(HesapKurduCaseStudy.Runner.RECTANGLE))
            {
                shape = String.Empty;
                Console.WriteLine("Please only write Circle,Triangle,Rectangle");
                shape = Console.ReadLine();
            }
            return shape;
        }
        private bool triangleChecker(string shape, bool triangleChecker)
        {
            string adjacentStr, oppositeStr, hypotenuseStr;
            double adjacentEdge, oppositeEdge, hypotenuseEdge;
            Console.WriteLine("Input the length of adjacent side");
            adjacentStr = Console.ReadLine();
            Double.TryParse(adjacentStr, out adjacentEdge);

            while (adjacentEdge <= 0)
            {
                Console.WriteLine(VALIDATION_MESSAGE);
                adjacentStr = Console.ReadLine();
                Double.TryParse(adjacentStr, out adjacentEdge);
            }

            Console.WriteLine("Input the length of opposite side");
            oppositeStr = Console.ReadLine();
            Double.TryParse(oppositeStr, out oppositeEdge);
            while (oppositeEdge <= 0)
            {
                Console.WriteLine(VALIDATION_MESSAGE);
                oppositeStr = Console.ReadLine();
                Double.TryParse(oppositeStr, out oppositeEdge);
            }

            Console.WriteLine("Input the length of hypotenuse");
            hypotenuseStr = Console.ReadLine();
            Double.TryParse(hypotenuseStr, out hypotenuseEdge);
            while (hypotenuseEdge <= 0)
            {
                Console.WriteLine(VALIDATION_MESSAGE);
                hypotenuseStr = Console.ReadLine();
                Double.TryParse(hypotenuseStr, out hypotenuseEdge);
            }

            while (Math.Pow(hypotenuseEdge, 2) != (Math.Pow(adjacentEdge, 2) + Math.Pow(oppositeEdge, 2)))
            {
                Console.WriteLine("Please enter right values for triangle definition");
                return false;
            }

            createShapes(shape, adjacentEdge, oppositeEdge, hypotenuseEdge);
            return true;

        }

        private void createShapes(string shape, double first, double second, double third)

        {
            double area, perimeter;
            switch (shape)
            {
                case CIRCLE:
                    Shape circle = new Circle(first);
                    area = circle.calculateArea();
                    perimeter = circle.calculatePerimeter();
                    Console.WriteLine(
                        $"Your shape is {shape} which has radius {first}. Your circle's perimeter is {perimeter} and it's surface area is {area}");
                    break;
                case RECTANGLE:
                    Shape rectangle = new Rectangle(second, third);
                    area = rectangle.calculateArea();
                    perimeter = rectangle.calculatePerimeter();
                    Console.WriteLine($"Your shape is {shape} which has height {second} and weight {third}. Your rectangle's perimeter is {perimeter} and it's surface area is {area}");
                    break;
                case TRIANGLE:
                    Shape triangle = new Triangle(first, second, third);
                    area = triangle.calculateArea();
                    perimeter = triangle.calculatePerimeter();
                    Console.WriteLine($"Your shape is {shape} which has adjacent side {first},opposite side {second} and hypotenuse {third}. Your triangle's perimeter is {perimeter} and it's surface area is {area}");
                    break;
                default:
                    break;
            }
        }
    }
}
