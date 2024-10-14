using Microsoft.EntityFrameworkCore;
using BlazorRecursivaProyectApp.Models;

namespace BlazorRecursivaProyectApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<HistorialConsultas> HistorialConsultas { get; set; }
    }
}
