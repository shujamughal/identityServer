using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.ViewModels
{
    public class RegisterClientViewModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "Length should not exceed 20 characters")]
        public string  ClientId { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Length should not exceed 20 characters")]
        public string  DisplayName { get; set; }
        [Required]
        [Url]
        public string  DisplayUrl { get; set; }
        [Required]
        [Url]
        public string  LogoUrl { get; set; }
        [Required]
        public string  Description { get; set; }

    }
}
