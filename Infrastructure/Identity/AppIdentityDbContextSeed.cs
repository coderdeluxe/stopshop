using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Monski",
                    Email = "mon@test.com",
                    UserName = "mon@test.com",
                    FirstName = "mon",
                    LastName = "monty",
                    Address = new Address
                    {
                        Street = "Eleven Street",
                        Barangay = "San Anddress",
                        City = "Cainta",
                        Province = "Riza"
                    }
                };

                await userManager.CreateAsync(user, "P@ssw0rd");
            }
        }
    }
}