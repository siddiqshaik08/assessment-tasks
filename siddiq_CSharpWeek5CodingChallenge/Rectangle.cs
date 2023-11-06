using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessement
{
    public class rectangle : Shape
    {
        private double length;
        private double breadth;

        public rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override double area()
        {
            //throw new NotImplementedException();
            return length * breadth;
        }

        public override double perimeter()
        {
            //throw new NotImplementedException();
            return 2 * (length + breadth);
        }
    }
}
