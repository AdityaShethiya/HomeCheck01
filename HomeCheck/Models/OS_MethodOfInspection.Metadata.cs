using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeCheck.Models
{
    [MetadataType(typeof(OS_MethodOfInspectionMetadata))]
    public partial class OS_MethodOfInspection
    {
    }


    internal sealed class OS_MethodOfInspectionMetadata
    {
        [Required(ErrorMessage = "Please enter Method of Inspection")]
        [Display(Name = "Method of Inspection")]
        public string methodOfInspection { get; set; }
        
    }
}