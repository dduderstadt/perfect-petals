    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // added
using System.Linq;
using System.Web;

namespace PerfectPetalsSite_v1.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^[0-9a-zA-Z]+([0-9a-zA-Z]*[-._+])*[0-9a-zA-Z]+@[0-9a-zA-Z]+([-.][0-9a-zA-Z]+)*([0-9a-zA-Z]*[.])[a-zA-Z]{2,6}$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Subject is required.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please select a date.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        public string Message { get; set; }
            
    } // end ContactViewModel
} // end namespace