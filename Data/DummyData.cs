using System;
using System.Threading.Tasks;
using HK.EntityModels;
using Microsoft.AspNetCore.Identity;

namespace HK.Data
{
    public class DummyData {
    public static async Task Initialize(ApplicationDbContext context,
                            UserManager<ApplicationUser> userManager,
                            RoleManager<ApplicationRole> roleManager)
    {
        context.Database.EnsureCreated();

        string adminId1 = "";
        string adminId2 = "";

        string role1 = "Admin";
        string desc1 = "This is the administrator role";
        
        string role2 = "Member";
        string desc2 = "This is the members role";

        string password = "P@$$w0rd";

        if (await roleManager.FindByNameAsync(role1) == null) {
            await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
        }
        if (await roleManager.FindByNameAsync(role2) == null) {
            await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
        }

        if (await userManager.FindByNameAsync("aa@aa.aa") == null) {
            var user = new ApplicationUser {
                UserName = "aa@aa.aa",
                Email = "aa@aa.aa",
                MemberSince = DateTime.Now
            };

            var result = await userManager.CreateAsync(user);
            if (result.Succeeded) {
                await userManager.AddPasswordAsync(user, password);
                await userManager.AddToRoleAsync(user, role1);
            }
            adminId1 = user.Id;
        }

        if (await userManager.FindByNameAsync("bb@bb.bb") == null) {
            var user = new ApplicationUser {
                UserName = "bb@bb.bb",
                Email = "bb@bb.bb",
                MemberSince = DateTime.Now
            };

            var result = await userManager.CreateAsync(user);
            if (result.Succeeded) {
                await userManager.AddPasswordAsync(user, password);
                await userManager.AddToRoleAsync(user, role1);
            }
            adminId2 = user.Id;
        }

        if (await userManager.FindByNameAsync("mm@mm.mm") == null) {
            var user = new ApplicationUser {
                UserName = "mm@mm.mm",
                Email = "mm@mm.mm",
                MemberSince = DateTime.Now
            };

            var result = await userManager.CreateAsync(user);
            if (result.Succeeded) {
                await userManager.AddPasswordAsync(user, password);
                await userManager.AddToRoleAsync(user, role2);
            }
        }

        if (await userManager.FindByNameAsync("dd@dd.dd") == null) {
            var user = new ApplicationUser {
                UserName = "dd@dd.dd",
                Email = "dd@dd.dd",
                MemberSince = DateTime.Now
            };

            var result = await userManager.CreateAsync(user);
            if (result.Succeeded) {
                await userManager.AddPasswordAsync(user, password);
                await userManager.AddToRoleAsync(user, role2);
            }
        }
    }
}
}