using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Fee { get; set; }
        public DateTime StartDate { get; set; }
        public int? CourseCategory { get; set; }

        public virtual Category? CourseCategoryNavigation { get; set; }
    }
}
