using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeCheck.Models
{
    [MetadataType(typeof(OS_AlarmMetadata))]
    public partial class OS_Alarm
    {
    }
    internal sealed class OS_AlarmMetadata
    {

        public int alarmID { get; set; }
        [Required(ErrorMessage = "Please enter Alarm")]
        [Display(Name = "Alarm")]
        public string alarm { get; set; }
    }
}