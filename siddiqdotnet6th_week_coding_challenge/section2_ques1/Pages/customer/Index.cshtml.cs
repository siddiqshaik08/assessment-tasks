using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using siddiq_6thassessment.Data;
using siddiq_6thassessment.model;

namespace siddiq_6thassessment.Pages.customer
{
    public class IndexModel : PageModel
    {
        private readonly siddiq_6thassessment.Data.siddiq_6thassessmentContext _context;

        public IndexModel(siddiq_6thassessment.Data.siddiq_6thassessmentContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Customer != null)
            {
                Customer = await _context.Customer.ToListAsync();
            }
        }
    }
}
