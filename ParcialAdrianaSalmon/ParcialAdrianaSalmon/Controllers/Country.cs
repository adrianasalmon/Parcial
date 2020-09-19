using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialAdrianaSalmon.Controllers
{
    public class Country
    {
        [Key]
        public string alpha3Code { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public string region { get; set; }


        [Required(ErrorMessage = "You must enter the field {0}")]
        public string name { get; set; }


        public int area { get; set; }


        public int callingCodes { get; set; }


        [Required(ErrorMessage = "You must enter the field {0}")]
        public string languages { get; set; }

        public string flag { get; set; }
    }
}