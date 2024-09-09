using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Infrastructure.Models;

namespace Backend.Infrastructure.Configuration
{
    public class MuscleConfiguration : IEntityTypeConfiguration<Muscle>
    {
        public void Configure(EntityTypeBuilder<Muscle> builder)
        {
            builder.ToTable("Muscle").HasKey(x => x.MuscleId);
            builder
                .Property(x => x.MuscleId)
                .IsRequired()
                .HasColumnName("MuscleId")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");
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
                .Property(x => x.PartOfBody)
                .IsRequired()
                .HasColumnName("PartOfBody")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.HasData(
                new Muscle
                {
                    MuscleId = 1,
                    Name = "Biceps Brachii",
                    Description =
                        "A muscle of the upper arm that acts to flex the elbow and supinate the forearm.",
                    UrlImage =
                        "https://www.kenhub.com/thumbor/0X8VRKFTJ5DT-6OaYklyFn42-xY=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/14480/biceps_intro.png",
                    PartOfBody = "Upper Arms"
                },
                new Muscle
                {
                    MuscleId = 2,
                    Name = "Triceps Brachii",
                    Description =
                        "A large muscle on the back of the upper arm, responsible for extending the elbow.",
                    UrlImage =
                        "https://www.kenhub.com/thumbor/HFbTJc2AayYsrOSJMmDE5axXPvs=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/13946/aHliOOl62koJhumoZcUysg_vsBTp2iDc2_M._triceps_brachii_1.png",
                    PartOfBody = "Upper Arms"
                },
                new Muscle
                {
                    MuscleId = 3,
                    Name = "Pectoralis Major",
                    Description =
                        "A thick, fan-shaped muscle situated at the chest of the body, responsible for moving the arm.",
                    UrlImage =
                        "https://www.kenhub.com/thumbor/rd8CbMjXA6gntGs93sl8EYIc6lI=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/13535/Wt6B7qUeKq5WqFGlzsQ_Musculus_pectoralis_major_01.png",
                    PartOfBody = "Chest"
                },
                new Muscle
                {
                    MuscleId = 4,
                    Name = "Rectus Abdominis",
                    Description =
                        "A paired muscle running vertically on each side of the anterior wall of the human abdomen.",
                    UrlImage =
                        "https://www.kenhub.com/thumbor/FyEucwQsZ4Kbhs4iErFa4jQplIc=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/article/rectus-abdominis-muscle/wwCbmBxMstOsHbXlWiA_jt6lkyuTYizDZFWnsiHpng_Musculus_rectus_abdominis_01.png",
                    PartOfBody = "Waist"
                },
                new Muscle
                {
                    MuscleId = 5,
                    Name = "Deltoid",
                    Description =
                        "A triangular muscle covering the shoulder joint and responsible for arm rotation.",
                    UrlImage =
                        "https://www.kenhub.com/thumbor/Si1vuP8MMgFOchicWEn_Vt4qzX0=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/13537/ZjXqXLfFvjRqzu4Ue14DA_degvezVumJ_M._deltoideus_2.png",
                    PartOfBody = "Shoulders"
                },
                // Adding missing muscle groups
                new Muscle
                {
                    MuscleId = 6,
                    Name = "Quadriceps",
                    Description =
                        "A large group of muscles located at the front of the thigh, responsible for extending the knee.",
                    UrlImage =
                        "https://www.kenhub.com/thumbor/08O0Lk96jBOozWw5dFgEB1G6MaM=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/13926/Op0rOgXqQB5W7THiS8Q_NmqapCoy4Z_M._quadriceps_femoris_NN_2__1_.png",
                    PartOfBody = "Thighs"
                },
                new Muscle
                {
                    MuscleId = 7,
                    Name = "Hamstrings",
                    Description =
                        "A group of muscles at the back of the thigh that work to flex the knee and extend the hip.",
                    UrlImage =
                        "https://www.kenhub.com/thumbor/0qdCfYj-eciZ64ynl_7cdsQz4KU=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/14013/Hamstring_muscles.png",
                    PartOfBody = "Thighs"
                }
            );
        }
    }
}
