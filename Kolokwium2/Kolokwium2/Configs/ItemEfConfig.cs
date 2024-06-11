using Kolokwium2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium2.Configs;

public class ItemEfConfig : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder
            .HasKey(it => it.IdItem)
            .HasName("item_pk");

        builder
            .Property(it => it.IdItem)
            .ValueGeneratedNever();

        builder
            .Property(it => it.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .Property(it => it.Weigth)
            .IsRequired();

        builder.ToTable(nameof(Item));
    }
}