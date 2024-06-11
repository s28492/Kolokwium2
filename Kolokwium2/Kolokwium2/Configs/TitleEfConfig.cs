using Kolokwium2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium2.Configs;

public class TitleEfConfig: IEntityTypeConfiguration<Title>
{
    public void Configure(EntityTypeBuilder<Title> builder)
    {
        builder
            .HasKey(it => it.IdTitle)
            .HasName("title_pk");

        builder
            .Property(it => it.IdTitle)
            .ValueGeneratedNever();
        
        builder
            .Property(it => it.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.ToTable(nameof(Title));
    }
}