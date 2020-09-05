using System;
using System.Collections.Generic;

namespace SchoolManagement.Models
{
    public partial class Student
    {
        public Student()
        {
            Project = new HashSet<Project>();
        }

        public string Stname { get; set; }
        public int Stid { get; set; }
        public int? Stage { get; set; }
        public int? Stclas { get; set; }

        public virtual ICollection<Project> Project { get; set; }
    }
}
