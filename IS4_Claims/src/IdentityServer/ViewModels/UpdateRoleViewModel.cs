using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.ViewModels
{
    public class UpdateRoleViewModel
    {
        public string Id { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
