﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UltimateBoards.Models;

namespace UltimateBoards.Migrations
{
    [DbContext(typeof(UltimateBoardsContext))]
    partial class UltimateBoardsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UltimateBoards.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("UltimateBoards.Models.Thread", b =>
                {
                    b.Property<int>("ThreadId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("ThreadId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Threads");
                });

            modelBuilder.Entity("UltimateBoards.Models.ThreadComment", b =>
                {
                    b.Property<int>("ThreadCommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("ThreadId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("ThreadCommentId");

                    b.HasIndex("ThreadId");

                    b.HasIndex("UserId");

                    b.ToTable("ThreadComments");
                });

            modelBuilder.Entity("UltimateBoards.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UltimateBoards.Models.Thread", b =>
                {
                    b.HasOne("UltimateBoards.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UltimateBoards.Models.User", "User")
                        .WithMany("Threads")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UltimateBoards.Models.ThreadComment", b =>
                {
                    b.HasOne("UltimateBoards.Models.Thread", "Thread")
                        .WithMany("Comments")
                        .HasForeignKey("ThreadId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UltimateBoards.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
