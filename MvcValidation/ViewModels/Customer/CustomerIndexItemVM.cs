using System;
using System.ComponentModel.DataAnnotations;

namespace MvcValidation.ControllersViewModels.Customer
{
    public class CustomerIndexItemVM
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}