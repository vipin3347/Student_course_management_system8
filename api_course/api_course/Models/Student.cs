using System;
using System.Collections.Generic;

namespace api_course.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public int PhoneNumber { get; set; }
        public int? CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
