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
    
    public partial class OS_Asbestos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OS_Asbestos()
        {
            this.heatingSystemMasters = new HashSet<heatingSystemMaster>();
        }
    
        public int asbestosID { get; set; }
        public string asbestos { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<heatingSystemMaster> heatingSystemMasters { get; set; }
    }
}