using Microsoft.EntityFrameworkCore;

namespace front_ensinosupApi.Models
{
    public class front_ensinosupContext : DbContext
    {
        public front_ensinosupContext(DbContextOptions<front_ensinosupContext> options) : base(options)
        {
        }
        public DbSet<front_ensinosupMatriculas> front_EnsinosupMatriculas {get; set;}
    }
}