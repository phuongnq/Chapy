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
    
    public partial class CpScheduleDetail
    {
        public int Id { get; set; }
        public int ScheduleID { get; set; }
        public int ClassID { get; set; }
        public int StaffID { get; set; }
        public System.DateTime Date { get; set; }
        public int TimezoneID { get; set; }
    
        public virtual CpScheduleDetail CpScheduleDetail1 { get; set; }
        public virtual CpScheduleDetail CpScheduleDetail2 { get; set; }
        public virtual CpSchedule CpSchedule { get; set; }
    }
}