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
    
    public partial class OS_walks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OS_walks()
        {
            this.exteriorMasters = new HashSet<exteriorMaster>();
        }
    
        public int walksID { get; set; }
        public string walks { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exteriorMaster> exteriorMasters { get; set; }
    }
}
