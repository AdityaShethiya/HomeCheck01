using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeCheck.Models
{
    
    [MetadataType(typeof(OS_AcOperationMetadata))]
    public partial class OS_AcOperation
    {
    }
    internal sealed class OS_AcOperationMetadata
    {

        public int acOperationID { get; set; }
        [Required(ErrorMessage = "Please enter AC Operation")]
        [Display(Name = "AC Operation")]
        public string acOperation { get; set; }
    }
}