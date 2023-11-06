using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessement
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
    }


    public interface IDriver
    {
        void driving();
    }

    public interface IStudent
    {
        void studying();
    }

    public interface IEmployee
    {
        void working();
    }

}
