using IdentityModel;
using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Extensions;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Data
{
    public class ConfigurationDbContext : IdentityServer4.EntityFramework.DbContexts.ConfigurationDbContext<ConfigurationDbContext>
    {
        private readonly ConfigurationStoreOptions _storeOptions;

        public ConfigurationDbContext(DbContextOptions<ConfigurationDbContext> options, ConfigurationStoreOptions storeOptions) : base(options, storeOptions)
        {
            _storeOptions = storeOptions;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureClientContext(_storeOptions);
            modelBuilder.ConfigureResourcesContext(_storeOptions);

            base.OnModelCreating(modelBuilder);
            ClientSeed(modelBuilder);
        }
        //Adding clients in Table of db
        private void ClientSeed(ModelBuilder builder)
        {
            builder.Entity<ApiResource>()
                .HasData(
                    new ApiResource
                    {
                        Id = 1,
                        Name = "web_api",
                        DisplayName = "My Web API"
                    }
                );

            builder.Entity<ApiScope>()
                .HasData(
                    new ApiScope
                    {
                        Id = 1,
                        Enabled = true,
                        Name = "web_api_read",
                        DisplayName = "Web Api Read",
                        Description = null,
                        Required = false,
                        Emphasize = false,
                        ShowInDiscoveryDocument = true,
                    }
                );
            builder.Entity<ApiScope>()
                .HasData(
                    new ApiScope
                    {
                        Id = 2,
                        Enabled = true,
                        Name = "web_api_write",
                        DisplayName = "Web Api write",
                        Description = null,
                        Required = false,
                        Emphasize = false,
                        ShowInDiscoveryDocument = true,
                    }
                );
            builder.Entity<ApiResourceScope>()
                .HasData(
                new ApiResourceScope
                {
                    Id = 11,
                    ApiResourceId = 1,
                    Scope="web_api_read"
                });




            builder.Entity<Client>()
                .HasData(
                    new Client
                    {
                        Id=1,
                        Enabled = true,
                        ClientId = "client",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = "Client",
                        Description = "JS client",
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                       
                    },
                    new Client
                    {
                        Id = 2,
                        Enabled = true,
                        ClientId = "ro.client",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = "RO",
                        Description = "Ro client",
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        
                    },
                    new Client
                    {
                        Id = 3,
                        Enabled = true,
                        ClientId = "mvc",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = "MVC Client",
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = false,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = true
                    },
                    new Client
                    {
                        Id = 4,
                        Enabled = true,
                        ClientId = "js",
                        ProtocolType = "oidc",
                        RequireClientSecret = false,
                        RequireConsent = true,
                        ClientName = "JavaScript client",
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = true,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = false
                    });

            builder.Entity<ClientGrantType>()
                .HasData(
                    new ClientGrantType
                    {
                        Id = 1,
                        GrantType = "client_credentials",
                        ClientId = 1
                    },
                    new ClientGrantType
                    {
                        Id = 2,
                        GrantType = "password",
                        ClientId = 2
                    },
                    new ClientGrantType
                    {
                        Id = 3,
                        GrantType = "hybrid",
                        ClientId = 3
                    },
                    new ClientGrantType
                    {
                        Id = 4,
                        GrantType = "authorization_code",
                        ClientId = 4
                    });

            builder.Entity<ClientScope>()
                .HasData(
                    new ClientScope
                    {
                        Id = 1,
                        Scope = "profile",
                        ClientId = 3
                    },
                    new ClientScope
                    {
                        Id = 2,
                        Scope = "profile",
                        ClientId = 4
                    },
                    new ClientScope
                    {
                        Id = 3,
                        Scope = "openid",
                        ClientId = 3
                    },
                    new ClientScope
                    {
                        Id = 4,
                        Scope = "openid",
                        ClientId = 4
                    },
                    new ClientScope
                    {
                        Id = 5,
                        Scope = "web_api",
                        ClientId = 1
                    }
                    ,
                    new ClientScope
                    {
                        Id = 6,
                        Scope = "web_api",
                        ClientId = 2
                    }
                    ,
                    new ClientScope
                    {
                        Id = 7,
                        Scope = "web_api",
                        ClientId = 3
                    }
                    ,
                    new ClientScope
                    {
                        Id = 8,
                        Scope = "web_api",
                        ClientId = 4
                    });

            builder.Entity<ClientSecret>()
                .HasData(
                        new ClientSecret
                        {
                            Id = 1,
                            Value = "secret".ToSha256(),
                            Type = "SharedSecret",
                            ClientId = 1
                        },
                        new ClientSecret
                        {
                            Id = 2,
                            Value = "secret".ToSha256(),
                            Type = "SharedSecret",
                            ClientId = 2
                        },
                        new ClientSecret
                        {
                            Id = 3,
                            Value = "secret".ToSha256(),
                            Type = "SharedSecret",
                            ClientId = 3
                        });

            builder.Entity<ClientPostLogoutRedirectUri>()
                .HasData(
                new ClientPostLogoutRedirectUri
                {
                    Id = 1,
                    PostLogoutRedirectUri = " http://localhost:3000",
                    ClientId = 3
                },
                new ClientPostLogoutRedirectUri
                {
                    Id = 2,
                    PostLogoutRedirectUri = " http://localhost:3000",
                    ClientId = 4
                });

            builder.Entity<ClientRedirectUri>()
                .HasData(
                new ClientRedirectUri
                {
                    Id = 1,
                    RedirectUri = " http://localhost:3000",
                    ClientId = 3
                },
                new ClientRedirectUri
                {
                    Id = 2,
                    RedirectUri = " http://localhost:3000",
                    ClientId = 4
                });

            builder.Entity<ClientCorsOrigin>()
                .HasData(
                new ClientCorsOrigin
                {
                    Id = 1,
                    Origin = " http://localhost:3000",
                    ClientId = 4
                });
        }

    }
}
