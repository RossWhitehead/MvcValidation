using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcValidation.ControllersViewModels.Customer
{
    public class CustomerCreateVM
    {
        [Required]
        [StringLength(100, ErrorMessage = "First Name cannot be longer than 100 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Last Name cannot be longer than 100 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Remote("ValidateEmail", "Customer", ErrorMessage = "Email is not available.")]
        [EmailAddress(ErrorMessage = "A valid email address is required.")]
        public string Email { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "Email does not match.")]
        public string ConfirmEmail { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}