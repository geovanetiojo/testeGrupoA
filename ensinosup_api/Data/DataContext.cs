using Microsoft.EntityFrameworkCore;
using ensinosup_api.Models;

namespace ensinosup_api.Data
{
    
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){ }
        public DbSet<Aluno> Alunos {get; set;}
    }

    
}