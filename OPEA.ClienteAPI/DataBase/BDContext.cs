using Microsoft.EntityFrameworkCore;
using OPEA.ClienteAPI.Models;

namespace OPEA.ClienteAPI.DataBase
{
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions<BDContext> options):base(options) {}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipoEmpresa> TipoEmpresas { get; set; }



    }
}
