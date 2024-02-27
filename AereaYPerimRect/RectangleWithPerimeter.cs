using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AereaYPerimRect
{
    class RectangleWithPerimeter : Rectangle
{
    public RectangleWithPerimeter(double l, double w) : base(l, w)
    {
    }

    public double CalculatePerimeter()
    {
        return 2 * (length + width);
    }
}
}
