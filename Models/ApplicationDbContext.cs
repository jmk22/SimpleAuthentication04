using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace SimpleAuthentication04.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
    }
}
