using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeCheck.Models
{
    [MetadataType(typeof(OS_AluminiumWiringMetadata))]
    public partial class OS_AluminiumWiring
    {
    }
    internal sealed class OS_AluminiumWiringMetadata
    {

        public int aluminiumWiringID { get; set; }
        [Required(ErrorMessage = "Please enter Aluminium Wiring")]
        [Display(Name = "Aluminium Wiring")]
        public string aluminiumWiring { get; set; }
    }
}