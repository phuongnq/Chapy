//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chapy
{
    using System;
    using System.Collections.Generic;
    
    public partial class CpStaffType
    {
        public CpStaffType()
        {
            this.CpStaffs = new HashSet<CpStaff>();
        }
    
        public int Id { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
    
        public virtual CpSchool CpSchool { get; set; }
        public virtual ICollection<CpStaff> CpStaffs { get; set; }
    }
}
