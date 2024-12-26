using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GamesForum.Models;

namespace GamesForum.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GamesForum.Models.Tag> Tag { get; set; } = default!;
        public DbSet<GamesForum.Models.Article> Article { get; set; } = default!;
    }
}
