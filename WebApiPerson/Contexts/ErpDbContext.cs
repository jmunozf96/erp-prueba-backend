using ErpSecurity.infrastructure.entities;
using ErpSecurity.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace WebApiPerson.Contexts
{
    public class ErpDbContext : DbContext, SecurityDbContext
    {
        public ErpDbContext(DbContextOptions<ErpDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
