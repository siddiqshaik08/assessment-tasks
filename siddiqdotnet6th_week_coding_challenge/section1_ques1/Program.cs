using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siddiq_6th_assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dataquery.enterproductinfo(1, "shoes", 1800, 8);
            // Dataquery.retreiveproducts();
            //Dataquery.updateproductqty();
            Dataquery.deleterecords(1);
            //Dataquery.entersalesinfo(20, 1, 2, 1800);
           // Dataquery.retreivesales();
        }
    }
}
