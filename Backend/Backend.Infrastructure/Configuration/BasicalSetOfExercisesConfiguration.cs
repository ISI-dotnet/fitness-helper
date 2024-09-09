using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Infrastructure.Models;

namespace Backend.Infrastructure.Configuration
{
    public class BasicalSetOfExercisesConfiguration
        : IEntityTypeConfiguration<BasicalSetOfExercises>
    {
        public void Configure(EntityTypeBuilder<BasicalSetOfExercises> builder)
        {
            builder.ToTable("BasicalSetOfExercises").HasKey(x => x.BasicalSetId);
            builder
                .Property(x => x.BasicalSetId)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnType("int")
                .HasColumnName("BasicalSetId");
            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("Name");
            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(2000)
                .HasColumnName("Description");
            builder
                .Property(x => x.UrlImage)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .HasColumnName("UrlImage");
            builder
                .Property(x => x.Section)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Section");

            builder.HasData(
                new BasicalSetOfExercises
                {
                    BasicalSetId = 1,
                    Name = "Full Body Mass Gain",
                    Description =
                        "A workout plan designed to target all major muscle groups for mass gain.",
                    UrlImage =
                        "https://www.dmoose.com/cdn/shop/articles/feature-image_8fe9c007-78d4-4a6e-b08c-20692f4b84b0.jpg?v=1682514044",
                    Section = 1 // Mass Gaining
                },
                new BasicalSetOfExercises
                {
                    BasicalSetId = 2,
                    Name = "Upper Body Bulk",
                    Description =
                        "An upper body workout focused on bulking up your chest, shoulders, and arms.",
                    UrlImage =
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQPdPHrTAb2xqkDfT7DMtU-2ddq8WBsTjZ-Pw&s",
                    Section = 1 // Mass Gaining
                },
                new BasicalSetOfExercises
                {
                    BasicalSetId = 3,
                    Name = "Fat Blasting Circuit",
                    Description =
                        "A high-intensity circuit workout for fat loss, combining cardio with strength exercises.",
                    UrlImage =
                        "https://skinnyms.com/wp-content/uploads/2016/05/5-Calorie-Crushing-No-Equipment-Exercises.jpg",
                    Section = 2 // Fat Loss
                },
                new BasicalSetOfExercises
                {
                    BasicalSetId = 4,
                    Name = "Legs and Abs Shred",
                    Description =
                        "A workout focused on sculpting your legs and abs, aimed at fat loss.",
                    UrlImage =
                        "https://hips.hearstapps.com/hmg-prod/images/gym-instructer-doing-lunges-with-kettlebells-royalty-free-image-1585227849.jpg",
                    Section = 2 // Fat Loss
                },
                new BasicalSetOfExercises
                {
                    BasicalSetId = 5,
                    Name = "Pro Athlete Strength Training",
                    Description =
                        "A high-intensity workout used by professional athletes to build overall strength.",
                    UrlImage =
                        "https://www.pogophysio.com.au/wp-content/uploads/weights-cody-blog.jpg",
                    Section = 3 // Best Athletes
                },
                new BasicalSetOfExercises
                {
                    BasicalSetId = 6,
                    Name = "Explosive Power Routine",
                    Description =
                        "An explosive workout routine focused on improving power and agility, used by elite athletes.",
                    UrlImage =
                        "https://educatefitness.co.uk/wp-content/uploads/2023/04/Incorporate-Explosive-Training-into-Your-Routine.webp",
                    Section = 3 // Best Athletes
                }
            );
        }
    }
}
