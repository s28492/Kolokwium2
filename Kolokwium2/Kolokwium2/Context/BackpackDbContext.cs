using Kolokwium2.Configs;
using Kolokwium2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Context;

public class BackpackDbContext : DbContext
{
    public virtual DbSet<Item> Items { get; set; }
    public virtual DbSet<Backpack> Backpacks { get; set; }
    public virtual DbSet<Character> Characters { get; set; }
    public virtual DbSet<CharacterTitle> CharacterTitles { get; set; }
    public virtual DbSet<Title> Titles { get; set; }
    
    
    public BackpackDbContext()
    {
        
    }
    
    public BackpackDbContext(DbContextOptions<BackpackDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ItemEfConfig).Assembly);
    }
}