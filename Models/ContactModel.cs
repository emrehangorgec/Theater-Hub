using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TheaterReservationPage.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please choose your gender")]
        public string Gender { get; set; }

    }
}