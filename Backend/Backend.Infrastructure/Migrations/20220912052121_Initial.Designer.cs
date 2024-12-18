﻿// <auto-generated />
using System;
using Backend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220912052121_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Backend.Infrastructure.Models.BasicalSetEfficiency", b =>
                {
                    b.Property<int>("EfficiencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EfficiencyId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EfficiencyId"), 1L, 1);

                    b.Property<int>("Abs")
                        .HasColumnType("int")
                        .HasColumnName("Abs");

                    b.Property<int>("Arms")
                        .HasColumnType("int")
                        .HasColumnName("Arms");

                    b.Property<int>("Back")
                        .HasColumnType("int")
                        .HasColumnName("Back");

                    b.Property<int>("BasicalSetId")
                        .HasColumnType("int");

                    b.Property<int>("Cardio")
                        .HasColumnType("int")
                        .HasColumnName("Cardio");

                    b.Property<int>("Chest")
                        .HasColumnType("int")
                        .HasColumnName("Chest");

                    b.Property<int>("Legs")
                        .HasColumnType("int")
                        .HasColumnName("Legs");

                    b.HasKey("EfficiencyId");

                    b.ToTable("BasicalSetEfficiency", (string)null);
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.BasicalSetExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BasicalSetId")
                        .HasColumnType("int")
                        .HasColumnName("BasicalSetId");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int")
                        .HasColumnName("ExerciseId");

                    b.HasKey("Id");

                    b.HasIndex("BasicalSetId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("BasicalSetExercise", (string)null);
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.BasicalSetOfExercises", b =>
                {
                    b.Property<int>("BasicalSetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BasicalSetId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("BasicalSetId");

                    b.ToTable("BasicalSetOfExercises", (string)null);
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.BasicalSetTraining", b =>
                {
                    b.Property<int>("BasicalTrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BasicalTrainingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BasicalTrainingId"), 1L, 1);

                    b.Property<int>("BasicalSetId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date")
                        .HasColumnName("Date");

                    b.Property<int>("Time")
                        .HasColumnType("int")
                        .HasColumnName("Time");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BasicalTrainingId");

                    b.HasIndex("BasicalSetId");

                    b.HasIndex("UserId");

                    b.ToTable("BasicalSetTraining", (string)null);
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ExerciseId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("UrlImage");

                    b.Property<string>("UrlVideo")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("UrlVideo");

                    b.HasKey("ExerciseId");

                    b.ToTable("Exercise", (string)null);
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.ExerciseMuscles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int")
                        .HasColumnName("ExerciseId");

                    b.Property<bool>("IsTarget")
                        .HasColumnType("bit")
                        .HasColumnName("IsTarget");

                    b.Property<int>("MuscleId")
                        .HasColumnType("int")
                        .HasColumnName("MuscleId");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("MuscleId");

                    b.ToTable("ExerciseMuscles", (string)null);
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.Muscle", b =>
                {
                    b.Property<int>("MuscleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MuscleId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MuscleId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("PartOfBody")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("PartOfBody");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("UrlImage");

                    b.HasKey("MuscleId");

                    b.ToTable("Muscle", (string)null);
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("LastName");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Password");

                    b.HasKey("UserId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.UserSetExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int")
                        .HasColumnName("ExerciseId");

                    b.Property<int>("UserSetId")
                        .HasColumnType("int")
                        .HasColumnName("UserSetId");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("UserSetId");

                    b.ToTable("UserSetExercise", (string)null);
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.UserSetOfExercises", b =>
                {
                    b.Property<int>("UserSetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserSetId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserSetId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserSetId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSetOfExercises", (string)null);
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.UserSetTraining", b =>
                {
                    b.Property<int>("UserTrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserTrainingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserTrainingId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date")
                        .HasColumnName("Date");

                    b.Property<int>("Time")
                        .HasColumnType("int")
                        .HasColumnName("Time");

                    b.Property<int>("UserSetId")
                        .HasColumnType("int");

                    b.HasKey("UserTrainingId");

                    b.HasIndex("UserSetId");

                    b.ToTable("UserSetTraining", (string)null);
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.BasicalSetExercise", b =>
                {
                    b.HasOne("Backend.Infrastructure.Models.BasicalSetOfExercises", "BasicalSetOfExercises")
                        .WithMany("BasicalSetExercises")
                        .HasForeignKey("BasicalSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Infrastructure.Models.Exercise", "Exercise")
                        .WithMany("BasicalSetExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BasicalSetOfExercises");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.BasicalSetOfExercises", b =>
                {
                    b.HasOne("Backend.Infrastructure.Models.BasicalSetEfficiency", "BasicalSetEfficiency")
                        .WithOne("BasicalSetOfExercises")
                        .HasForeignKey("Backend.Infrastructure.Models.BasicalSetOfExercises", "BasicalSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BasicalSetEfficiency");
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.BasicalSetTraining", b =>
                {
                    b.HasOne("Backend.Infrastructure.Models.BasicalSetOfExercises", "BasicalSetOfExercises")
                        .WithMany("BasicalSetTrainings")
                        .HasForeignKey("BasicalSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Infrastructure.Models.User", "User")
                        .WithMany("BasicalSetTrainings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BasicalSetOfExercises");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.ExerciseMuscles", b =>
                {
                    b.HasOne("Backend.Infrastructure.Models.Exercise", "Exercise")
                        .WithMany("ExerciseMuscles")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Infrastructure.Models.Muscle", "Muscle")
                        .WithMany("ExerciseMuscles")
                        .HasForeignKey("MuscleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Muscle");
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.UserSetExercise", b =>
                {
                    b.HasOne("Backend.Infrastructure.Models.Exercise", "Exercise")
                        .WithMany("UserSetsExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Infrastructure.Models.UserSetOfExercises", "UserSetOfExercises")
                        .WithMany("UserSetsExercises")
                        .HasForeignKey("UserSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("UserSetOfExercises");
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.UserSetOfExercises", b =>
                {
                    b.HasOne("Backend.Infrastructure.Models.User", "User")
                        .WithMany("UserSetsOfExercises")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.UserSetTraining", b =>
                {
                    b.HasOne("Backend.Infrastructure.Models.UserSetOfExercises", "UserSetOfExercises")
                        .WithMany("UserSetTrainings")
                        .HasForeignKey("UserSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserSetOfExercises");
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.BasicalSetEfficiency", b =>
                {
                    b.Navigation("BasicalSetOfExercises")
                        .IsRequired();
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.BasicalSetOfExercises", b =>
                {
                    b.Navigation("BasicalSetExercises");

                    b.Navigation("BasicalSetTrainings");
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.Exercise", b =>
                {
                    b.Navigation("BasicalSetExercises");

                    b.Navigation("ExerciseMuscles");

                    b.Navigation("UserSetsExercises");
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.Muscle", b =>
                {
                    b.Navigation("ExerciseMuscles");
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.User", b =>
                {
                    b.Navigation("BasicalSetTrainings");

                    b.Navigation("UserSetsOfExercises");
                });

            modelBuilder.Entity("Backend.Infrastructure.Models.UserSetOfExercises", b =>
                {
                    b.Navigation("UserSetTrainings");

                    b.Navigation("UserSetsExercises");
                });
#pragma warning restore 612, 618
        }
    }
}
