using ModelValidation.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ModelValidation.Models
{
    [NoJoeOnMondays]
    public class Appointment
    {
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        [Remote("ValidateDate", "Home")]
        //[Required(ErrorMessage = "Please enter a date")]
        //[FutureDate(ErrorMessage = "Please enter a date in the future")]
        public DateTime Date { get; set; }

        //[Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms")]
        //[MustBeTrue(ErrorMessage = "You must accept the terms")]
        public bool TermsAccepted { get; set; }
    }
}