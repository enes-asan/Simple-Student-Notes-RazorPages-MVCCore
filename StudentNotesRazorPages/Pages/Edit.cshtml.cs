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
    public class EditModel : PageModel
    {
        public StudentNotesContext _context;
        public EditModel(StudentNotesContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Student Student { get; set; }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = _context.Students.FirstOrDefault(p => p.id == id);
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                var editEntity = _context.Entry(Student);
                editEntity.State = EntityState.Modified;
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
