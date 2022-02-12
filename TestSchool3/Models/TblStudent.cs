using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TestSchool3.Models
{
    public partial class TblStudent
    {
        public string Idnumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentId { get; set; }
        public int? SchoolYear { get; set; }
        public string Gender { get; set; }
    }
}
