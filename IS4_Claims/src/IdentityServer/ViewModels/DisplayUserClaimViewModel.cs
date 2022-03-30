using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.ViewModels
{
    public class DisplayUserClaimViewModel
    {
        public DisplayUserClaimViewModel()
        {
            Claims = new List<string>();
        }
        public string Username { get; set; }
        public List<string> Claims{ get; set; }
    }
}
