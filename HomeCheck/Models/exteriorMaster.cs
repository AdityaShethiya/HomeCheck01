//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeCheck.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class exteriorMaster
    {
        public int exteriorID { get; set; }
        public Nullable<int> propertyID { get; set; }
        public Nullable<int> grading { get; set; }
        public Nullable<int> vegetation { get; set; }
        public Nullable<int> walks { get; set; }
        public Nullable<int> steps { get; set; }
        public Nullable<int> doors { get; set; }
        public Nullable<int> siding { get; set; }
        public Nullable<int> decks { get; set; }
        public Nullable<int> driveway { get; set; }
        public Nullable<int> eaves { get; set; }
        public Nullable<int> balconies { get; set; }
        public Nullable<int> overallCondition { get; set; }
        public string comments { get; set; }
        public Nullable<int> drivewayCondition { get; set; }
        public Nullable<int> exteriorPaint { get; set; }
        public Nullable<int> inspectionID { get; set; }
        public Nullable<System.DateTime> sdate { get; set; }
        public Nullable<System.DateTime> lastModified { get; set; }
    
        public virtual inspectionMaster inspectionMaster { get; set; }
        public virtual OS_Balconies OS_Balconies { get; set; }
        public virtual OS_Condition OS_Condition { get; set; }
        public virtual OS_Decks OS_Decks { get; set; }
        public virtual OS_Doors OS_Doors { get; set; }
        public virtual OS_Driveway OS_Driveway { get; set; }
        public virtual OS_DrivewayCondition OS_DrivewayCondition { get; set; }
        public virtual OS_eaves OS_eaves { get; set; }
        public virtual OS_ExteriorPaint OS_ExteriorPaint { get; set; }
        public virtual OS_Grading OS_Grading { get; set; }
        public virtual OS_Siding OS_Siding { get; set; }
        public virtual OS_Steps OS_Steps { get; set; }
        public virtual OS_Vegetation OS_Vegetation { get; set; }
        public virtual OS_walks OS_walks { get; set; }
        public virtual propertyMaster propertyMaster { get; set; }
    }
}