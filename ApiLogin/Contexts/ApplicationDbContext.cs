using ApiLogin.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLogin.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
