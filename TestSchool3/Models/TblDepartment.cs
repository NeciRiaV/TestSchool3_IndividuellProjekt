using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TestSchool3.Models
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblStaff = new HashSet<TblStaff>();
            TblTdep = new HashSet<TblTdep>();
        }

        public int DepId { get; set; }
        public string DepName { get; set; }

        public virtual ICollection<TblStaff> TblStaff { get; set; }
        public virtual ICollection<TblTdep> TblTdep { get; set; }
    }
}
