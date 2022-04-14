using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.ViewModels
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
            Genders = new List<string>() {"Male","Female","Others" };
            Degrees = new List<string>() {"PhD","MS","BS" };
            UDegree = new List<UserDegree>();

        }
        [Required]
        [StringLength(20,ErrorMessage ="Length should not exceed 20 characters")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Gender { get; set; }
        public List<string> Genders { get; set; }

        [Required]
        public List<UserDegree> UDegree { get; set; }
        public List<string> Degrees { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password must match with confirmation password")]
        public string ConfirmPassword { get; set; }
    }
}
