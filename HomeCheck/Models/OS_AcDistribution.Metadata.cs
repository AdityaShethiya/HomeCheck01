using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeCheck.Models
{
    [MetadataType(typeof(OS_AcDistributionMetadata))]
    public partial class OS_AcDistribution
    {
    }
    internal sealed class OS_AcDistributionMetadata
    {
       
        public int acDistributionID { get; set; }
        [Required(ErrorMessage = "Please enter Method of Inspection")]
        [Display(Name = "AC Distribution")]
        public string acDistribution { get; set; }
    }
}