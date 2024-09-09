using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Infrastructure.Models;

namespace Backend.Infrastructure.Configuration
{
    public class AchievmentConfiguration : IEntityTypeConfiguration<Achievment>
    {
        public void Configure(EntityTypeBuilder<Achievment> builder)
        {
            builder.ToTable("Achievment").HasKey(x => x.AchievmentId);
            builder
                .Property(x => x.AchievmentId)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("AchievmentId")
                .HasColumnType("int");
            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(max)");
            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("varchar(max)");
            builder
                .Property(x => x.UrlImage)
                .IsRequired()
                .HasColumnName("UrlImage")
                .HasColumnType("varchar(max)");

            builder.HasData(
                new Achievment
                {
                    AchievmentId = 1,
                    Name = "First Steps",
                    Description = "Finish Your First Training Session",
                    UrlImage = "https://cdn-icons-png.flaticon.com/512/7173/7173358.png"
                },
                new Achievment
                {
                    AchievmentId = 2,
                    Name = "On The Right Way",
                    Description = "Finish 10 Training Sessions",
                    UrlImage =
                        "https://www.k2ksigns.com.au/cdn/shop/products/TRS45-PedestrianRightway_1200x1200.jpg?v=1681423354"
                },
                new Achievment
                {
                    AchievmentId = 3,
                    Name = "You Got Better",
                    Description = "Finish 50 Training Sessions",
                    UrlImage =
                        "https://png.pngtree.com/png-vector/20240805/ourlarge/pngtree-retro-distressed-sticker-of-a-cartoon-burning-direction-arrow-png-image_13088695.png"
                },
                new Achievment
                {
                    AchievmentId = 4,
                    Name = "Learn From The Best",
                    Description = "Finish 5 Basical Training Sessions",
                    UrlImage =
                        "https://thumbs.dreamstime.com/b/strong-arm-showing-biceps-muscle-strong-arm-showing-its-biceps-muscle-illustration-134575504.jpg"
                },
                new Achievment
                {
                    AchievmentId = 5,
                    Name = "Train On Your Own",
                    Description = "Finish 5 Your Own Trainings",
                    UrlImage =
                        "https://images.emojiterra.com/google/noto-emoji/unicode-15.1/color/1024px/1f60e.png"
                },
                new Achievment
                {
                    AchievmentId = 6,
                    Name = "Creator",
                    Description = "Create your first custom workout plan",
                    UrlImage = "https://images.emojiterra.com/twitter/v13.1/512px/1f5d2.png"
                },
                new Achievment
                {
                    AchievmentId = 7,
                    Name = "Researcher",
                    Description = "Explore 5 different workout plans",
                    UrlImage =
                        "https://cdn1.iconfinder.com/data/icons/smashicons-emoticons-retro-vol-1/60/37_-_Explorer_emoticon_emoji_face-512.png"
                }
            );
        }
    }
}
