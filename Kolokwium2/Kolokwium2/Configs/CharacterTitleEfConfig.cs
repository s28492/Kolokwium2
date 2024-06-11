using Kolokwium2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium2.Configs;

public class CharachterTitleEfConfig: IEntityTypeConfiguration<CharacterTitle>
{
    public void Configure(EntityTypeBuilder<CharacterTitle> builder)
    {
        builder
            .HasKey(x => new { x.CharacterId, x.TitleId })
            .HasName("characterTitles_pk");

        builder
            .HasOne(x => x.Character)
            .WithMany(x => x.CharacterTitles)
            .HasForeignKey(x => x.CharacterId)
            .HasConstraintName("characterTitles_characters")
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasOne(x => x.Title)
            .WithMany(x => x.CharacterTitles)
            .HasForeignKey(x => x.TitleId)
            .HasConstraintName("characterTitles_titles")
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(x => x.AcquiredAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");
        
        
        //not to be plural
        builder.ToTable(nameof(CharacterTitle));
    }
}