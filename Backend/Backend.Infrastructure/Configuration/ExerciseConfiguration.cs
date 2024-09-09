using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Infrastructure.Models;

namespace Backend.Infrastructure.Configuration
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.ToTable("Exercise").HasKey(x => x.ExerciseId);
            builder
                .Property(x => x.ExerciseId)
                .IsRequired()
                .HasColumnName("ExerciseId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();
            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar")
                .HasMaxLength(100);
            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("varchar")
                .HasMaxLength(2000);
            builder
                .Property(x => x.UrlImage)
                .IsRequired()
                .HasColumnName("UrlImage")
                .HasColumnType("varchar")
                .HasMaxLength(500);
            builder
                .Property(x => x.UrlVideo)
                .IsRequired()
                .HasColumnName("UrlVideo")
                .HasColumnType("varchar")
                .HasMaxLength(500);

            builder.HasData(
                new Exercise
                {
                    ExerciseId = 1,
                    Name = "Barbell Bench Press",
                    Description =
                        "A basic upper body exercise targeting the pectoral muscles, triceps, and shoulders.",
                    UrlImage =
                        "https://cdn.muscleandstrength.com/sites/default/files/barbell-bench-press_0.jpg",
                    UrlVideo = "https://www.youtube.com/watch?v=rT7DgCr-3pg"
                },
                new Exercise
                {
                    ExerciseId = 2,
                    Name = "Bicep Curl",
                    Description =
                        "An isolation exercise focusing on the biceps for strength and size.",
                    UrlImage =
                        "https://www.verywellfit.com/thmb/plk9oJP3KcuRnBaq8bk3sGrsVjM=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/81-3498604-Bicep-arm-curlsGIF2-c7c59f252b1a4ef9b1e181ca05e96084.jpg",
                    UrlVideo = "https://www.youtube.com/watch?v=ykJmrZ5v0Oo"
                },
                new Exercise
                {
                    ExerciseId = 3,
                    Name = "Squat",
                    Description =
                        "A compound exercise primarily working the quadriceps, hamstrings, and glutes.",
                    UrlImage =
                        "https://res.cloudinary.com/peloton-cycle/image/fetch/f_auto,c_limit,w_3840,q_90/https://downloads.ctfassets.net/6ilvqec50fal/1EHc7nNZ4VqgTjyKoNnyvd/08a03edafa59cf2f74b591765cc68c62/Barbell-squat.jpg",
                    UrlVideo = "https://www.youtube.com/watch?v=xqvCmoLULNY"
                }
            );
        }
    }
}
