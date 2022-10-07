using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaSolarAPI.Entities;

namespace SistemaSolarAPI
{
    public class PlanetaMap : IEntityTypeConfiguration<Planeta>
    {

        public void Configure(EntityTypeBuilder<Planeta> builder)
        {

            builder.ToTable("Planetas");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(70);
            builder.Property(p => p.Massa)
                .IsRequired()
                .HasColumnType("int");
            builder.Property(p => p.Distancia)
                .IsRequired()
                .HasColumnType("int");
        }

    }
}
