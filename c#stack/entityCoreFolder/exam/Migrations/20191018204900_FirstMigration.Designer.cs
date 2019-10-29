﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exam.Models;

namespace exam.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20191018204900_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("exam.Models.Relationship", b =>
                {
                    b.Property<int>("RelationshipId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Accepted");

                    b.Property<int>("RequesteeId");

                    b.Property<int>("RequesterId");

                    b.HasKey("RelationshipId");

                    b.HasIndex("RequesteeId");

                    b.HasIndex("RequesterId");

                    b.ToTable("Relationships");
                });

            modelBuilder.Entity("exam.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

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

            modelBuilder.Entity("exam.Models.Relationship", b =>
                {
                    b.HasOne("exam.Models.User", "Requestee")
                        .WithMany("RequestedMe")
                        .HasForeignKey("RequesteeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("exam.Models.User", "Requester")
                        .WithMany("IRequested")
                        .HasForeignKey("RequesterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}