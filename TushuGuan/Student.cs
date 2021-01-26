using System;
using System.Collections.Generic;
using System.Text;

namespace TushuGuan
{
    public class Student
    {
        public string StudentID { get; set; }
        public List<BookBorrowed> Lend { get; set; }
    }
}
