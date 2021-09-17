using Microsoft.EntityFrameworkCore;
using StudentNotesRazorPages.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentNotesRazorPages.Models
{
    public class StudentNotesContext:DbContext
    {
        public StudentNotesContext(DbContextOptions<StudentNotesContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
