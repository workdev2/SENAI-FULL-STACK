using Microsoft.EntityFrameworkCore;

namespace LHPet.Models
{
    public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
    {
        public DbSet<Cliente> Cliente { get; set; }
        }
    }

