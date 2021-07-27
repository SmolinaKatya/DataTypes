using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTypesSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure() { NumberOfSides = 3, SideLength = 5};
            FigureStruct figure1 = new FigureStruct() { NumberOfSides = 10, SideLength = 3 };
            CountArea(figure);
            Console.WriteLine("Number of sides = {0}, side length = {1}, area = {2:N2}", figure.NumberOfSides, figure.SideLength, figure.Area);
            CountArea1(ref figure);
            Console.WriteLine("Number of sides = {0}, side length = {1}, area = {2:N2}", figure.NumberOfSides, figure.SideLength, figure.Area);
            CountArea2(ref figure1);
            Console.WriteLine("Number of sides = {0}, side length = {1}, area = {2:N2}", figure1.NumberOfSides, figure1.SideLength, figure1.Area);
        }

        public static object CountArea(Figure figureOrig)
        {
            figureOrig.Area = figureOrig.NumberOfSides * Math.Pow(figureOrig.SideLength, 2) / (4 * Math.Tan(Math.PI / figureOrig.NumberOfSides));
            return figureOrig;
        }

        public static object CountArea1(ref Figure figureRef)
        {
            figureRef = new Figure() { NumberOfSides = 7, SideLength = 5 };
            figureRef.Area = figureRef.NumberOfSides * Math.Pow(figureRef.SideLength, 2) / (4 * Math.Tan(Math.PI / figureRef.NumberOfSides));
            return figureRef.Area;
        }

        public static object CountArea2(ref FigureStruct figureOrig)
        {
            figureOrig.Area = figureOrig.NumberOfSides * Math.Pow(figureOrig.SideLength, 2) / (4 * Math.Tan(Math.PI / figureOrig.NumberOfSides));
            return figureOrig;
        }
    }
}
