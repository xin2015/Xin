using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Xin.Web.Models
{
    // 可以通过向 ApplicationUser 类添加更多属性来为用户添加配置文件数据。若要了解详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=317594。
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }

        public ApplicationUser(string userName) : base(userName) { }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // 请注意，authenticationType 必须与 CookieAuthenticationOptions.AuthenticationType 中定义的相应项匹配
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // 在此处添加自定义用户声明
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        static ApplicationDbContext()
        {
            Database.SetInitializer<ApplicationDbContext>(new DatabaseInitializer());
        }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            PerformInitialSetup(context);
            base.Seed(context);
        }

        public void PerformInitialSetup(ApplicationDbContext context)
        {
            ApplicationUserManager userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            ApplicationRoleManager roleManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(context));
            string roleName = "admin";
            string userName = "admin";
            string password = "Admin2016!@";

            if (!roleManager.RoleExists(roleName))
            {
                roleManager.Create(new ApplicationRole(roleName));
            }

            ApplicationUser user = userManager.FindByName(userName);
            if (user == null)
            {
                userManager.Create(new ApplicationUser(userName), password);
                user = userManager.FindByName(userName);
            }

            if (!userManager.IsInRole(user.Id, roleName))
            {
                userManager.AddToRole(user.Id, roleName);
            }
        }
    }

    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }
    }
}