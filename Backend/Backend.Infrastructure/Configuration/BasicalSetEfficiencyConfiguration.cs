using Backend.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infrastructure.Configuration
{
    public class BasicalSetEfficiencyConfiguration : IEntityTypeConfiguration<BasicalSetEfficiency>
    {
        public void Configure(EntityTypeBuilder<BasicalSetEfficiency> builder)
        {
            builder.ToTable("BasicalSetEfficiency").HasKey(x => x.EfficiencyId);
            builder
                .Property(x => x.EfficiencyId)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("EfficiencyId")
                .HasColumnType("int");
            builder
                .Property(x => x.Cardio)
                .HasColumnName("Cardio")
                .HasColumnType("int")
                .IsRequired();
            builder.Property(x => x.Legs).HasColumnName("Legs").HasColumnType("int").IsRequired();
            builder.Property(x => x.Arms).HasColumnName("Arms").HasColumnType("int").IsRequired();
            builder.Property(x => x.Back).HasColumnName("Back").HasColumnType("int").IsRequired();
            builder.Property(x => x.Chest).HasColumnName("Chest").HasColumnType("int").IsRequired();
            builder.Property(x => x.Abs).HasColumnName("Abs").HasColumnType("int").IsRequired();
            builder
                .Property(x => x.Cardio)
                .HasColumnName("Cardio")
                .HasColumnType("int")
                .IsRequired();

            builder.HasData(
                new BasicalSetEfficiency
                {
                    EfficiencyId = 1,
                    Cardio = 0,
                    Legs = 4,
                    Arms = 3,
                    Back = 1,
                    Chest = 5,
                    Abs = 2,
                    BasicalSetId = 1,
                },
                new BasicalSetEfficiency
                {
                    EfficiencyId = 2,
                    Cardio = 1,
                    Legs = 0,
                    Arms = 3,
                    Back = 1,
                    Chest = 4,
                    Abs = 2,
                    BasicalSetId = 2,
                },
                new BasicalSetEfficiency
                {
                    EfficiencyId = 3,
                    Cardio = 1,
                    Legs = 3,
                    Arms = 2,
                    Back = 1,
                    Chest = 0,
                    Abs = 3,
                    BasicalSetId = 3,
                },
                new BasicalSetEfficiency
                {
                    EfficiencyId = 4,
                    Cardio = 0,
                    Legs = 5,
                    Arms = 0,
                    Back = 1,
                    Chest = 0,
                    Abs = 2,
                    BasicalSetId = 4,
                },
                new BasicalSetEfficiency
                {
                    EfficiencyId = 5,
                    Cardio = 1,
                    Legs = 3,
                    Arms = 2,
                    Back = 1,
                    Chest = 0,
                    Abs = 3,
                    BasicalSetId = 5,
                },
                new BasicalSetEfficiency
                {
                    EfficiencyId = 6,
                    Cardio = 0,
                    Legs = 0,
                    Arms = 3,
                    Back = 1,
                    Chest = 0,
                    Abs = 2,
                    BasicalSetId = 6,
                }
            );
        }
    }
}
