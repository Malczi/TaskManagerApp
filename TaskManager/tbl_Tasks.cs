//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Tasks
    {
        public int IdTask { get; set; }
        public int IdCategory { get; set; }
        public string TaskName { get; set; }
        public int IdWorkers { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<int> IdStatus { get; set; }
        public Nullable<int> IdTaskPriority { get; set; }
    
        public virtual tbl_TaskCategories tbl_TaskCategories { get; set; }
        public virtual tbl_TaskPriority tbl_TaskPriority { get; set; }
        public virtual tbl_TaskStatus tbl_TaskStatus { get; set; }
        public virtual tbl_Workers tbl_Workers { get; set; }
    }
}