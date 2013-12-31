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
    
    public partial class CpSchool
    {
        public CpSchool()
        {
            this.CpStaffs = new HashSet<CpStaff>();
            this.CpStartEndDates = new HashSet<CpStartEndDate>();
            this.CpTannins = new HashSet<CpTannin>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CorporationId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Representation { get; set; }
        public string PrinceName1 { get; set; }
        public string PrinceName2 { get; set; }
        public string PostCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public Nullable<byte> UsePass { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
    
        public virtual ICollection<CpStaff> CpStaffs { get; set; }
        public virtual ICollection<CpStartEndDate> CpStartEndDates { get; set; }
        public virtual ICollection<CpTannin> CpTannins { get; set; }
    }
}