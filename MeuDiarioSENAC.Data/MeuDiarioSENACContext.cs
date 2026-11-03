using Microsoft.EntityFrameworkCore;

class MeuDiarioSENACContext : DbContext
{
    public DbSet<Registro> Registros { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    
    private readonly string connectionString =
        "server=gateway01.ap-northeast-1.prod.aws.tidbcloud.com;port=4000;database=MeuDiarioSENAC;uid=2fv6EHCNTpUWmBy.root;pwd=WZiscClPEJha5pVh;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString,
            ServerVersion.AutoDetect(connectionString));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>()
            .HasMany(u => u.Registros)
            .WithOne(r => r.Usuario)
            .HasForeignKey(r => r.UsuarioId);
    }
}