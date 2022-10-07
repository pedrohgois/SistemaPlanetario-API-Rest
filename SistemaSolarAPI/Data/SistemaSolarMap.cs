using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaSolarAPI.Entities;

namespace SistemaSolarAPI
{
    public class SistemaSolarMap : IEntityTypeConfiguration<SistemaSolar>
    {
        public void Configure(EntityTypeBuilder<SistemaSolar> builder)
        {
            builder.ToTable("SistemaSolares");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(70);
            builder.Property(s => s.MassaEstrela)
                .IsRequired()
                .HasColumnType("int");
        }

    }
}

