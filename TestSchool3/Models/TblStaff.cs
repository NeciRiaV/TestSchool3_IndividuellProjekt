using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TestSchool3.Models
{
    public partial class TblStaff
    {
        public TblStaff()
        {
            TblClasses = new HashSet<TblClasses>();
        }

        public string IdentityNumber { get; set; }
        public string FullName { get; set; }
        public int StaffId { get; set; }
        public string WorkPosition { get; set; }
        public string FirstDay { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public int DepId { get; set; }

        public virtual TblDepartment Dep { get; set; }
        public virtual ICollection<TblClasses> TblClasses { get; set; }
    }
}
