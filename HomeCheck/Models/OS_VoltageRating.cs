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
    
    public partial class OS_VoltageRating
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OS_VoltageRating()
        {
            this.electricalMasters = new HashSet<electricalMaster>();
        }
    
        public int voltageRatingID { get; set; }
        public string voltageRating { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<electricalMaster> electricalMasters { get; set; }
    }
}
