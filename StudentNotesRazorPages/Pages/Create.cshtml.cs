using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentNotesRazorPages.Entities;
using StudentNotesRazorPages.Models;

namespace StudentNotesRazorPages.Pages
{
    public class CreateModel : PageModel
    {
       public StudentNotesContext _context;
        public CreateModel(StudentNotesContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        [BindProperty]
        public Student Student { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                var addEntity = _context.Entry(Student);
                addEntity.State = EntityState.Added;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return Page();
            }
            return RedirectToPage("/index");

        }


    }
}
