using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessement
{
    public class role : Person, IDriver, IStudent, IEmployee
    {
        public role(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void driving()
        {
            Console.WriteLine("driver drives the car");
            Console.WriteLine(name + age + address);

        }

        public void studying()
        {
            Console.WriteLine("student is studying");
            Console.WriteLine(name + age + address);

        }

        public void working()
        {
            Console.WriteLine("worker is working");
            Console.WriteLine(name + age + address);

        }

    }
}
