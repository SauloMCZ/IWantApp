using IWantApp.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace IWantApp.InfraEstrutura.Data;

public class applicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public applicationDbContext(DbContextOptions<applicationDbContext> options) : base(options) { } //construtou usa tags fixas

    protected override void OnModelCreating(ModelBuilder builder) // metodo atribuindo campos obrigatorios e tamanhos especificos
    {
        builder.Entity<Product>().Property(p => p.Category).IsRequired();

        builder.Entity<Product>().Property(p => p.Description).HasMaxLength(155);

        builder.Entity<Category>().Property(c => c.Name).IsRequired();
    }
    protected override void ConfigureConventions(ModelConfigurationBuilder configuration) //metodo atribuindo a string tamanho maximo
    {
        configuration.Properties<string>().HaveMaxLength(100);
    }

}