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
    
    public partial class plumbingMaster
    {
        public int plumbingID { get; set; }
        public Nullable<System.DateTime> sdate { get; set; }
        public Nullable<System.DateTime> lastModified { get; set; }
        public Nullable<int> propertyID { get; set; }
        public Nullable<int> inspectionID { get; set; }
        public string comments { get; set; }
        public Nullable<int> waterMain { get; set; }
        public Nullable<int> waterMainDiameter { get; set; }
        public Nullable<int> waterSupplyPiping { get; set; }
        public Nullable<int> waste { get; set; }
        public Nullable<int> drainVent { get; set; }
        public Nullable<int> hotWaterSystem { get; set; }
        public Nullable<int> overallCondition { get; set; }
        public Nullable<int> tNPPiping { get; set; }
    
        public virtual inspectionMaster inspectionMaster { get; set; }
        public virtual OS_Condition OS_Condition { get; set; }
        public virtual OS_DrainVent OS_DrainVent { get; set; }
        public virtual OS_HotWaterSystem OS_HotWaterSystem { get; set; }
        public virtual OS_TnPPipping OS_TnPPipping { get; set; }
        public virtual OS_Waste OS_Waste { get; set; }
        public virtual OS_WaterMain OS_WaterMain { get; set; }
        public virtual OS_WaterMainDiameter OS_WaterMainDiameter { get; set; }
        public virtual OS_WaterSupplyPiping OS_WaterSupplyPiping { get; set; }
        public virtual propertyMaster propertyMaster { get; set; }
    }
}
