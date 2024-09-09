using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Infrastructure.Models;

namespace Backend.Infrastructure.Configuration
{
    public class BasicalSetExerciseConfiguration : IEntityTypeConfiguration<BasicalSetExercise>
    {
        public void Configure(EntityTypeBuilder<BasicalSetExercise> builder)
        {
            builder.ToTable("BasicalSetExercise").HasKey(x => x.Id);
            builder
                .Property(x => x.Id)
                .HasColumnType("int")
                .HasColumnName("Id")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(x => x.ExerciseId)
                .HasColumnType("int")
                .HasColumnName("ExerciseId")
                .IsRequired();
            builder
                .Property(x => x.BasicalSetId)
                .HasColumnType("int")
                .HasColumnName("BasicalSetId")
                .IsRequired();

            // Seed data
            builder.HasData(
                // Full Body Mass Gain
                new BasicalSetExercise
                {
                    Id = 1,
                    BasicalSetId = 1, // Full Body Mass Gain
                    ExerciseId = 1 // Barbell Bench Press
                },
                new BasicalSetExercise
                {
                    Id = 2,
                    BasicalSetId = 1, // Full Body Mass Gain
                    ExerciseId = 3 // Squat
                },
                // Upper Body Bulk
                new BasicalSetExercise
                {
                    Id = 3,
                    BasicalSetId = 2, // Upper Body Bulk
                    ExerciseId = 1 // Barbell Bench Press
                },
                new BasicalSetExercise
                {
                    Id = 4,
                    BasicalSetId = 2, // Upper Body Bulk
                    ExerciseId = 2 // Bicep Curl
                },
                // Fat Blasting Circuit
                new BasicalSetExercise
                {
                    Id = 5,
                    BasicalSetId = 3, // Fat Blasting Circuit
                    ExerciseId = 1 // Barbell Bench Press
                },
                new BasicalSetExercise
                {
                    Id = 6,
                    BasicalSetId = 3, // Fat Blasting Circuit
                    ExerciseId = 3 // Squat
                },
                // Legs and Abs Shred
                new BasicalSetExercise
                {
                    Id = 7,
                    BasicalSetId = 4, // Legs and Abs Shred
                    ExerciseId = 3 // Squat
                },
                // Pro Athlete Strength Training
                new BasicalSetExercise
                {
                    Id = 8,
                    BasicalSetId = 5, // Pro Athlete Strength Training
                    ExerciseId = 1 // Barbell Bench Press
                },
                new BasicalSetExercise
                {
                    Id = 9,
                    BasicalSetId = 5, // Pro Athlete Strength Training
                    ExerciseId = 3 // Squat
                },
                // Explosive Power Routine
                new BasicalSetExercise
                {
                    Id = 10,
                    BasicalSetId = 6, // Explosive Power Routine
                    ExerciseId = 2 // Bicep Curl
                }
            );
        }
    }
}
