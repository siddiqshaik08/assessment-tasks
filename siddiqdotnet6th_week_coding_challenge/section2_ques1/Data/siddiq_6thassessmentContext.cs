using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using siddiq_6thassessment.model;

namespace siddiq_6thassessment.Data
{
    public class siddiq_6thassessmentContext : DbContext
    {
        public siddiq_6thassessmentContext (DbContextOptions<siddiq_6thassessmentContext> options)
            : base(options)
        {
        }

        public DbSet<siddiq_6thassessment.model.Customer> Customer { get; set; } = default!;

        public DbSet<siddiq_6thassessment.model.Orders>? Orders { get; set; }

        public DbSet<siddiq_6thassessment.model.Product>? Product { get; set; }
    }
}
