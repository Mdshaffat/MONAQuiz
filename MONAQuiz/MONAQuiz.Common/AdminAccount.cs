using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MonaQuiz.Data;
using MONAQuiz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quizaldo.Common
{
    public class AdminAccount
    {
        public static void SetupAdminAccount(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                if (!roleManager.RoleExistsAsync("Admin").Result)
                {
                    roleManager.CreateAsync(new IdentityRole("Admin")).Wait();
                }

                if (userManager.FindByNameAsync("admin").Result == null)
                {
                    var adminUser = new ApplicationUser();
                    adminUser.UserName = "afroza@gmail.com";
                    adminUser.Email = "afroza@gmail.com";
                    adminUser.Name = "Afroza Khatun";

                    string adminPassword = "Admin@01";

                    IdentityResult result = userManager.CreateAsync(adminUser, adminPassword).Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(adminUser, "Admin").Wait();
                    }
                }
            }
        }
    }
}
