using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hades.OAuth.Configuration
{
    public static class InMemoryConfigurations
    {
        public static IEnumerable<ApiResource> ApiResources()
        {
            return new[]
            {
                new ApiResource("hadesapi", "Hades Api")
        };
        }
        public static IEnumerable<Client> Clients()
        {
            return new[]
            {
                new Client{
                ClientId = "hadesapi",
                ClientSecrets = new []{ new Secret ("secret".Sha256()) },
                AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                AllowedScopes = new[]{ "hadesapi"}
                }
        };
        }
        public static IEnumerable<TestUser> Users()
        {
            return new[]
            {
                new TestUser{
                SubjectId="1",
                Username = "admin@email.com",
                Password = "password"
                }
        };
        }

    }
}
