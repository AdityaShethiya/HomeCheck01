using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeCheck.Models
{
    
    [MetadataType(typeof(OS_ApproximateAgeMetadata))]
    public partial class OS_ApproximateAge
    {
    }
    internal sealed class OS_ApproximateAgeMetadata
    {

        public int approximateAgeID { get; set; }
        [Required(ErrorMessage = "Please enter Approximate Age")]
        [Display(Name = "Approximate Age")]
        public string approximateAge { get; set; }
    }
}