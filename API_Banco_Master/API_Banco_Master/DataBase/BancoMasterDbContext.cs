using API_Banco_Master.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Banco_Master.DataBase
{
    public class BancoMasterDbContext : DbContext
    {
        public BancoMasterDbContext(DbContextOptions<BancoMasterDbContext> options) : base(options) { }

        public DbSet<Cliente> Clietes { get; set; }
        public DbSet<Transferencia> Transferencias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuild)
        {
            modelBuild.ApplyConfigurationsFromAssembly(typeof(BancoMasterDbContext).Assembly);
            base.OnModelCreating(modelBuild);
        }
    }
}
