using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AereaYPerimRect
{
    class Rectangle
    {
          protected double length;
    protected double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double CalculateArea()
    {
        return length * width;
    }
    }
}
