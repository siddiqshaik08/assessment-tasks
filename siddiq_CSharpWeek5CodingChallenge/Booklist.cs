using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessement
{
    public class book : IEquatable<book>
    {
        public string title { get; set; }
        public string author { get; set; }
        public int isbn { get; set; }

        bool IEquatable<book>.Equals(book other)
        {
            throw new NotImplementedException();
            //return title + author + isbn;
        }
        public override string ToString()
        {
            return title +" " +" "+ author+" " +" "+ isbn;
        }
    }
}
