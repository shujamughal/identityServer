using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer.ViewModels;

namespace IdentityServer
{
    public class Config
    {
        private static Client MyClient { get; set; }
        public static void SetClients(RegisterClientViewModel c)
        {
            

                // interactive client using code flow + pkce
            // new Client
            //    {
            //        ClientId = "interactive",
            //        ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

            //        AllowedGrantTypes = GrantTypes.Code,

            //        RedirectUris = { "https://localhost:44300/signin-oidc" },
            //        FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
            //        PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },

            //        AllowOfflineAccess = true,
            //        AllowedScopes = { "openid", "profile", "scope2" }
            //    }
            //}



        // m2m client credentials flow client
        var cl = new Client
                {
                    ClientId = c.ClientId,
                    ClientName = c.DisplayName,
                    ClientUri = c.DisplayUrl,
                    LogoUri = c.LogoUrl,
                    Description = c.Description
                };
            MyClient = cl;
        }
        public static Client GetClient()
        {
            return new Client
            {
                ClientId = "interactive",
                ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                AllowedGrantTypes = GrantTypes.Code,

                RedirectUris = { "https://localhost:44300/signin-oidc" },
                FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },

                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "scope2" }

            };
        //return MyClient;
        }

        public static Client Clients()
        {

            // m2m client credentials flow client

            // interactive client using code flow + pkce
            return new Client
            {
                ClientId = "interactive",
                ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                AllowedGrantTypes = GrantTypes.Code,

                RedirectUris = { "https://localhost:44300/signin-oidc" },
                FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },

                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "scope2" }
            };
           
        }


    }
}
