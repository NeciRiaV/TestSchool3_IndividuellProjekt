using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TestSchool3.Models
{
    public partial class TeacherDep
    {
        public int? TdepId { get; set; }
        public int? StaffId { get; set; }

        public virtual TblStaff Staff { get; set; }
        public virtual TblTdep Tdep { get; set; }
    }
}
