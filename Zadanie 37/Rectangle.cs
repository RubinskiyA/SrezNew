using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_37
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Lenght { get; set; }
        public Rectangle(double x, double y)
        {
            Width = x;
            Lenght = y;
        }
        public double Perimetr()
        {
            return (Width + Lenght) *2;
        }
        public double Area()
        {
            return Width * Lenght;
        }
    }
}
