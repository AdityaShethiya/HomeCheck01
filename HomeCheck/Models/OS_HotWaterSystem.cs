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
    
    public partial class OS_HotWaterSystem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OS_HotWaterSystem()
        {
            this.plumbingMasters = new HashSet<plumbingMaster>();
        }
    
        public int hotWaterSystemID { get; set; }
        public string hotWaterSystem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<plumbingMaster> plumbingMasters { get; set; }
    }
}
