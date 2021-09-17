using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentNotesRazorPages.Entities
{
    public class Student
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Class { get; set; }
        public string CourseName { get; set; }
        public int MidtermExam { get; set; }
        public int FinalExam { get; set; }

    }
}
