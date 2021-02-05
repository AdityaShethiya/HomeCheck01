using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeCheck.Models
{
	
    [MetadataType(typeof(OS_AdditionalBuildingsMetadata))]
    public partial class OS_AdditionalBuildings
    {
    }
    internal sealed class OS_AdditionalBuildingsMetadata
    {

        public int additionalBuildingID { get; set; }
        [Required(ErrorMessage = "Please enter Additional Building")]
        [Display(Name = "Additional Building")]
        public string additionalBuilding { get; set; }
    }
}