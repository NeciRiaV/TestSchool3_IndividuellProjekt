using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TestSchool3.Models
{
    public partial class TblStudentClasses
    {
        public int StudentIdclass { get; set; }
        public string StudentFullName { get; set; }
        public int ClassIdstudent { get; set; }

        public virtual TblClasses ClassIdstudentNavigation { get; set; }
        public virtual TblStudent StudentIdclassNavigation { get; set; }
    }
}
