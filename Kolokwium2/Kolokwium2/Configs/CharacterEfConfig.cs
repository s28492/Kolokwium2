using Kolokwium2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium2.Configs;

public class CharacterEfConfig : IEntityTypeConfiguration<Character>
{
    public void Configure(EntityTypeBuilder<Character> builder)
    {
        builder
            .HasKey(k => k.Id)
            .HasName("id_pk");

        builder
            .Property(x => x.Id)
            .ValueGeneratedNever();

        builder
            .Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(50);
        
        builder
            .Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(120);

        builder
            .Property(x => x.CurrentWei)
            .IsRequired();
        
        builder
            .Property(x => x.MaxWeigth)
            .IsRequired();
        
        
        //not to be plural
        builder.ToTable(nameof(Character));
    }
}