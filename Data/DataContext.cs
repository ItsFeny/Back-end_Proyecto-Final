using BackEnd_ProyectoFinal.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_ProyectoFinal.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> ventas { get; set; }

    }
}
