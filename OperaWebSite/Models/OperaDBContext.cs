using Microsoft.EntityFrameworkCore;

namespace OperaWebSite.Models
{
    public class OperaDBContext:DbContext
    {
     public OperaDBContext(DbContextOptions<OperaDBContext> options) : base(options) { }

        public DbSet<Opera> Operas { get; set; }

        //agregar DBSET para trabajar con la colección de empleados
        public DbSet<Empleado> Empleados { get; set; }


    }


       
}
