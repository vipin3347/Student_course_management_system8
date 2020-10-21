using System;
using System.Collections.Generic;

namespace api_course
{
    public partial class Course
    {
        public Course()
        {
            Student = new HashSet<Student>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
