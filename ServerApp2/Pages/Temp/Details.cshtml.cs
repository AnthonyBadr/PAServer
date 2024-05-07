using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServerApp2.Data;
using ServerApp2.Models;

namespace ServerApp2.Pages.Temp
{
    public class DetailsModel : PageModel
    {
        private readonly ServerApp2.Data.ApplicationDbContext _context;

        public DetailsModel(ServerApp2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Course Course { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }
            else 
            {
                Course = course;
            }
            return Page();
        }
    }
}
