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
    
    public partial class electricalMaster
    {
        public int electricalID { get; set; }
        public Nullable<System.DateTime> sdate { get; set; }
        public Nullable<System.DateTime> lastModified { get; set; }
        public Nullable<int> propertyID { get; set; }
        public Nullable<int> inspectionID { get; set; }
        public string comments { get; set; }
        public Nullable<int> serviceEntry { get; set; }
        public Nullable<int> panelFeed { get; set; }
        public Nullable<int> voltageRating { get; set; }
        public Nullable<int> panelLabel { get; set; }
        public Nullable<int> wireType { get; set; }
        public Nullable<int> overloadProtection { get; set; }
        public Nullable<int> mainPanelLocation { get; set; }
        public Nullable<int> subPanelLocation { get; set; }
        public Nullable<int> ground { get; set; }
        public Nullable<int> smokeDetectors { get; set; }
        public Nullable<int> aluminumWiring { get; set; }
        public Nullable<int> overallCondition { get; set; }
        public Nullable<int> alarm { get; set; }
        public Nullable<bool> twoPromgOutlets { get; set; }
        public Nullable<bool> paintedOutlets { get; set; }
        public Nullable<int> atticOpenWires { get; set; }
        public Nullable<int> openSpliceBoxes { get; set; }
        public string ReversePolarity { get; set; }
        public Nullable<bool> openGrounds { get; set; }
        public Nullable<bool> openBulbsClosets { get; set; }
        public Nullable<bool> oversizedBreakers { get; set; }
        public Nullable<bool> tappedBreakers { get; set; }
    
        public virtual inspectionMaster inspectionMaster { get; set; }
        public virtual OS_Alarm OS_Alarm { get; set; }
        public virtual OS_AluminiumWiring OS_AluminiumWiring { get; set; }
        public virtual OS_AtticOpenWire OS_AtticOpenWire { get; set; }
        public virtual OS_Condition OS_Condition { get; set; }
        public virtual OS_Ground OS_Ground { get; set; }
        public virtual OS_MainPanelLocation OS_MainPanelLocation { get; set; }
        public virtual OS_OpenSpliceBoxes OS_OpenSpliceBoxes { get; set; }
        public virtual OS_OverloadProtection OS_OverloadProtection { get; set; }
        public virtual OS_PanelFeed OS_PanelFeed { get; set; }
        public virtual OS_PanelLabel OS_PanelLabel { get; set; }
        public virtual OS_ServiceEntry OS_ServiceEntry { get; set; }
        public virtual OS_SmokeDetectors OS_SmokeDetectors { get; set; }
        public virtual OS_SubPanelLocation OS_SubPanelLocation { get; set; }
        public virtual OS_VoltageRating OS_VoltageRating { get; set; }
        public virtual OS_WireType OS_WireType { get; set; }
        public virtual propertyMaster propertyMaster { get; set; }
    }
}
