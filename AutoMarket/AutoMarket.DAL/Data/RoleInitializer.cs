using AutoMarket.DAL.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Data
{
    public class RoleInitializer
    {
        public static async Task InitializerAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@mail.com";
            string password = "admin123.main";

            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User
                {
                    Email = adminEmail,
                    UserName = adminEmail,
                    FirstName = "Жантай"
                };

                var result = await userManager.CreateAsync(admin, password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }
    }
}