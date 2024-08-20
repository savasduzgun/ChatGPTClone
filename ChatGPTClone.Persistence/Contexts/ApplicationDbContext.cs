using ChatGPTClone.Domain.Entities;
using ChatGPTClone.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChatGPTClone.Persistence.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, Role, Guid, AppUserClaim, AppUserRole, AppUserLogin, RoleClaim, AppUserToken>
    {
        public DbSet<ChatSession> ChatSessions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
