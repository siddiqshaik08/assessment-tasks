﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using siddiq_6thassessment.Data;
using siddiq_6thassessment.model;

namespace siddiq_6thassessment.Pages.customer
{
    public class CreateModel : PageModel
    {
        private readonly siddiq_6thassessment.Data.siddiq_6thassessmentContext _context;

        public CreateModel(siddiq_6thassessment.Data.siddiq_6thassessmentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Customer == null || Customer == null)
            {
                return Page();
            }

            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
