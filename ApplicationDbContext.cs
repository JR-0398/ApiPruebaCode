using Microsoft.EntityFrameworkCore;
using ApiPruebaCode.Models;

namespace ApiPruebaCode
{
    public class ApplicationDbContext :DbContext{
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Detalle> DETALLE_DIRECCION{get;set;}
        public DbSet<Usuario> USUARIOS{get;set;}
        public DbSet<paVirtual> paVirtuals{get;set;}
    }
}