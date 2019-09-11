using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Rent_A_Car.Models
{
    public class ContractCreateViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Name") ]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Lastname")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Licence Number")]
        public int LicenceNumber { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Contact")]
        public int Contact { get; set; }
        [Required]
        [Display(Name = "Vehicle")]
        public string Vehicle { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime Start { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.DateTime)]
        public DateTime Return { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }
    }
}