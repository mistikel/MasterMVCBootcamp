namespace MvcBootcamp.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MvcBootcamp.Web.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcBootcamp.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MvcBootcamp.Web.Models.ApplicationDbContext";
        }

        protected override void Seed(MvcBootcamp.Web.Models.ApplicationDbContext context)
        {
            if (!context.Users.Any(u => u.UserName == "admin3"))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                var user = new ApplicationUser { UserName = "admin3" };
                userManager.Create(user, "123456");
                roleManager.Create(new IdentityRole { Name = "Administrator3" });
                userManager.AddToRole(user.Id, "Administrator3");
            }

            if (!context.Users.Any(u => u.UserName == "mistiawan1"))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                var user = new ApplicationUser { UserName = "mistiawan1" };
                userManager.Create(user, "123456");
                roleManager.Create(new IdentityRole { Name = "Members3" });
                userManager.AddToRole(user.Id, "Members3");
            }
        }
    }
}
