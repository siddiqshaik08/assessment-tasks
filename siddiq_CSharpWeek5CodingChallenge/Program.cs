using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assessement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<book> bk = new List<book>();
            bk.Add(new book() { title = "the .net developer", author = "abdul", isbn = 1287653 });
            bk.Add(new book() { title = "the power", author = "peter", isbn = 87509345});
            bk.Add(new book() { title = "three thousand stitches", author = "sudha murthy", isbn = 98436712 });
            bk.Add(new book() { title = "subconsious mind", author = "stacy", isbn = 79438793 });

            Console.WriteLine("the books details are");
            foreach (book abook in bk){
                Console.WriteLine(abook);
            }

            

        //multiinterface();

        // areaperi();

           }

        private static void multiinterface()
        {
            role r = new role("sid", 21, "khammam");
            //console to printvalues
            r.driving();
            Console.WriteLine($"the driver name is");

            r.studying();
            Console.WriteLine("the student name is");

            r.working();
            Console.WriteLine("the employee name is");
        }

        private static void areaperi()
        {
            Shape circ = new Circle(10);
            Shape rect = new rectangle(15, 18);
            Shape tri = new triangle(5, 9, 8);

            Console.WriteLine($"the area of circle is {circ.area()}");
            Console.WriteLine($"the perimeter of circle is {circ.perimeter()}");

            Console.WriteLine($"the area of triangle is {tri.area()}");
            Console.WriteLine($"the perimeter of triangle is {tri.perimeter()}");

            Console.WriteLine($"the area of rectangle is {rect.area()}");
            Console.WriteLine($"the perimeter of rectangle is {rect.perimeter()}");
        }
    }
}

