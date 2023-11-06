using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessement
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double area()
        {
            // throw new NotImplementedException();
            return 3.1416 * radius * radius;
        }

        public override double perimeter()
        {
            //throw new NotImplementedException();
            return 2 * 3.1416 * radius;

        }
    }
}
