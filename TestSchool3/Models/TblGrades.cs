using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TestSchool3.Models
{
    public partial class TblGrades
    {
        public int StudentIdgrades { get; set; }
        public int Idclass { get; set; }
        public decimal? Grade { get; set; }
        public DateTime? DateOfGrade { get; set; }
        public int TeacherIdgrades { get; set; }

        public virtual TblClasses IdclassNavigation { get; set; }
        public virtual TblStudent StudentIdgradesNavigation { get; set; }
        public virtual TblStaff TeacherIdgradesNavigation { get; set; }
    }
}
