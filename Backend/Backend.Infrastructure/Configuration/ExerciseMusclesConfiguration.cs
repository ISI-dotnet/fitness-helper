using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Infrastructure.Models;

namespace Backend.Infrastructure.Configuration
{
    public class ExerciseMusclesConfiguration : IEntityTypeConfiguration<ExerciseMuscles>
    {
        public void Configure(EntityTypeBuilder<ExerciseMuscles> builder)
        {
            builder.ToTable("ExerciseMuscles").HasKey(x => x.Id);
            builder
                .Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("int");
            builder
                .Property(x => x.ExerciseId)
                .IsRequired()
                .HasColumnName("ExerciseId")
                .HasColumnType("int");
            builder
                .Property(x => x.MuscleId)
                .IsRequired()
                .HasColumnName("MuscleId")
                .HasColumnType("int");
            builder
                .Property(x => x.IsTarget)
                .IsRequired()
                .HasColumnName("IsTarget")
                .HasColumnType("bit");

            builder.HasData(
                // Barbell Bench Press (Primary: Pectoralis Major, Secondary: Triceps Brachii, Deltoid)
                new ExerciseMuscles
                {
                    Id = 1,
                    ExerciseId = 1,
                    MuscleId = 3,
                    IsTarget = true
                }, // Pectoralis Major
                new ExerciseMuscles
                {
                    Id = 2,
                    ExerciseId = 1,
                    MuscleId = 2,
                    IsTarget = false
                }, // Triceps Brachii
                new ExerciseMuscles
                {
                    Id = 3,
                    ExerciseId = 1,
                    MuscleId = 5,
                    IsTarget = false
                }, // Deltoid
                // Bicep Curl (Primary: Biceps Brachii, Secondary: Deltoid)
                new ExerciseMuscles
                {
                    Id = 4,
                    ExerciseId = 2,
                    MuscleId = 1,
                    IsTarget = true
                }, // Biceps Brachii
                new ExerciseMuscles
                {
                    Id = 5,
                    ExerciseId = 2,
                    MuscleId = 5,
                    IsTarget = false
                }, // Deltoid
                // Squat (Primary: Quadriceps, Secondary: Rectus Abdominis, Deltoid)
                new ExerciseMuscles
                {
                    Id = 6,
                    ExerciseId = 3,
                    MuscleId = 4,
                    IsTarget = true
                }, // Rectus Abdominis
                new ExerciseMuscles
                {
                    Id = 7,
                    ExerciseId = 3,
                    MuscleId = 5,
                    IsTarget = false
                } // Deltoid
            );
        }
    }
}
