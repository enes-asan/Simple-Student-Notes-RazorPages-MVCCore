using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentNotesRazorPages.Entities;
using StudentNotesRazorPages.Models;

namespace StudentNotesRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public StudentNotesContext _context;
        public IndexModel(StudentNotesContext context)
        {
            _context = context;
        }
        public List<Student> Students { get; set; }
        public void OnGet()
        {
            Students = _context.Students.ToList();
        }
    }
}
