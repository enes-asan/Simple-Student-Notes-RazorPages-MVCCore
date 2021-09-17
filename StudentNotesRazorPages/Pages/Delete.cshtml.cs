using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentNotesRazorPages.Entities;
using StudentNotesRazorPages.Models;
using Microsoft.EntityFrameworkCore;
namespace StudentNotesRazorPages.Pages
{
    public class DeleteModel : PageModel
    {
        public StudentNotesContext _context;
        public DeleteModel(StudentNotesContext context)
        {
            _context = context;
        }
        public Student Student { get; set; }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return Page();
            }

            Student = _context.Students.FirstOrDefault(p => p.id == id);

            try
            {
                var deleteEntity = _context.Entry(Student);
                deleteEntity.State = EntityState.Deleted;
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
