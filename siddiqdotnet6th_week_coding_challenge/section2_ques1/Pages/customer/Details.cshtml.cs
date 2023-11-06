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
    public class DetailsModel : PageModel
    {
        private readonly siddiq_6thassessment.Data.siddiq_6thassessmentContext _context;

        public DetailsModel(siddiq_6thassessment.Data.siddiq_6thassessmentContext context)
        {
            _context = context;
        }

      public Customer Customer { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FirstOrDefaultAsync(m => m.customerid == id);
            if (customer == null)
            {
                return NotFound();
            }
            else 
            {
                Customer = customer;
            }
            return Page();
        }
    }
}
