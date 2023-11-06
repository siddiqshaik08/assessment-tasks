using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessement
{
    public class triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double area()
        {
            //throw new NotImplementedException();

            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

        }

        public override double perimeter()
        {
            // throw new NotImplementedException();
            return side1 + side2 + side3;
        }
    }
}
