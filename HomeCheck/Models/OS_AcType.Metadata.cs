using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeCheck.Models
{
    
    [MetadataType(typeof(OS_AcTypeMetadata))]
    public partial class OS_AcType
    {
    }
    internal sealed class OS_AcTypeMetadata
    {

        public int acTypeID { get; set; }
        [Required(ErrorMessage = "Please enter AC Type")]
        [Display(Name = "AC Type")]
        public string acType { get; set; }
    }
}