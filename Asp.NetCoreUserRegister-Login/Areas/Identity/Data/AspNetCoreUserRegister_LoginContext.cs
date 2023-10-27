using Asp.NetCoreUserRegister_Login.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Asp.NetCoreUserRegister_Login.Data;

public class AspNetCoreUserRegister_LoginContext : IdentityDbContext<ApplicationUser>
{
    public AspNetCoreUserRegister_LoginContext(DbContextOptions<AspNetCoreUserRegister_LoginContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
