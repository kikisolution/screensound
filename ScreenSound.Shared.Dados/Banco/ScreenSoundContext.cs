using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using ScreenSound.Shared.Modelos.Modelos;

namespace ScreenSound.Banco;

public class ScreenSoundContext : DbContext
{
    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Musica> Musicas { get; set; }
    public DbSet<Genero> Generos { get; set; }
    // private string connectionString = "Server=localhost,1433;Database=ScreeSoundV0;User ID=SA;Password=Password_01;Trusted_Connection=False; TrustServerCertificate=True; MultipleActiveResultSets=true";
    private string connectionString = "Server=tcp:screensoundserverkiki.database.windows.net,1433;Initial Catalog=ScreenSoundV0;Persist Security Info=False;User ID=ezequias;Password=2440@Eze;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(connectionString, b => b.MigrationsAssembly("ScreenSound"))
            .UseLazyLoadingProxies();
    }

    // Relacionamento entre as tabelas Músicas e Genero. 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Musica>()
            .HasMany(c => c.Generos)
            .WithMany(c => c.Musicas);
    }

}