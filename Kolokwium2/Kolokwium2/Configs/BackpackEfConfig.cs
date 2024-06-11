using Kolokwium2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium2.Configs;

public class BackpacksEfConfig : IEntityTypeConfiguration<Backpack>
{
    public void Configure(EntityTypeBuilder<Backpack> builder)
    {
        builder
            .HasKey(x => new { x.CharacterId, x.ItemId })
            .HasName("backpacks_pk");

        builder
            .HasOne(x => x.Item)
            .WithMany(x => x.Backpacks)
            .HasForeignKey(x => x.ItemId)
            .HasConstraintName("backpacs_items")
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasOne(x => x.Character)
            .WithMany(x => x.Backpacks)
            .HasForeignKey(x => x.CharacterId)
            .HasConstraintName("backpacs_characters")
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(x => x.Amount)
            .IsRequired();
        
        
        //not to be plural
        builder.ToTable(nameof(Backpack));
    }
}