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
    
    public partial class roofMaster
    {
        public int roofID { get; set; }
        public Nullable<System.DateTime> sdate { get; set; }
        public Nullable<System.DateTime> lastModified { get; set; }
        public Nullable<int> propertyID { get; set; }
        public Nullable<int> inspectionID { get; set; }
        public Nullable<int> methodOfInspection { get; set; }
        public Nullable<int> roofingMaterial { get; set; }
        public Nullable<int> approximateAge { get; set; }
        public Nullable<int> noOfLayers { get; set; }
        public Nullable<int> flashing { get; set; }
        public Nullable<int> tarPaper { get; set; }
        public Nullable<int> chimneyComposition { get; set; }
        public Nullable<int> skyLights { get; set; }
        public Nullable<int> roofDrainage { get; set; }
        public Nullable<int> atticVentilation { get; set; }
        public Nullable<int> overallCondition { get; set; }
        public string comments { get; set; }
    
        public virtual inspectionMaster inspectionMaster { get; set; }
        public virtual OS_ApproximateAge OS_ApproximateAge { get; set; }
        public virtual OS_AtticVentilation OS_AtticVentilation { get; set; }
        public virtual OS_ChimneyComposition OS_ChimneyComposition { get; set; }
        public virtual OS_Condition OS_Condition { get; set; }
        public virtual OS_Flashing OS_Flashing { get; set; }
        public virtual OS_MethodOfInspection OS_MethodOfInspection { get; set; }
        public virtual OS_NoOfLayers OS_NoOfLayers { get; set; }
        public virtual OS_RoofDrainage OS_RoofDrainage { get; set; }
        public virtual OS_RoofingMaterial OS_RoofingMaterial { get; set; }
        public virtual OS_SkyLights OS_SkyLights { get; set; }
        public virtual OS_TarPaper OS_TarPaper { get; set; }
        public virtual propertyMaster propertyMaster { get; set; }
    }
}
