using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeCheck.Models
{
    [MetadataType(typeof(OS_AsbestosMetadata))]
    public partial class OS_Asbestos
    {
    }
    internal sealed class OS_AsbestosMetadata
    {
        public int asbestosID { get; set; }
        [Required(ErrorMessage = "Please enter Asbestos")]
        [Display(Name = "Asbestos")]
        public string asbestos { get; set; }
    }
}