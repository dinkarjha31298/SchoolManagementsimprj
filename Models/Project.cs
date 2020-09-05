using System;
using System.Collections.Generic;

namespace SchoolManagement.Models
{
    public partial class Project
    {
        public string Prname { get; set; }
        public int Prid { get; set; }
        public int? Stid { get; set; }

        public virtual Student St { get; set; }
    }
}
