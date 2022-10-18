﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFirstAPI.Models;

#nullable disable

namespace MyFirstAPI.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20221018034456_USerAdded")]
    partial class USerAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyFirstAPI.Models.Department", b =>
                {
                    b.Property<int>("Dep_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dep_Id"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dep_Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Dep_Id = 1,
                            DepartmentName = "Admin"
                        });
                });

            modelBuilder.Entity("MyFirstAPI.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Username");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            DepartmentId = 1,
                            Name = "Ramu",
                            Salary = 12345.54f,
                            Username = "ramu"
                        },
                        new
                        {
                            Id = 102,
                            DepartmentId = 1,
                            Name = "Somu",
                            Salary = 34535.54f
                        });
                });

            modelBuilder.Entity("MyFirstAPI.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Username = "ramu",
                            Password = "1234",
                            Role = "admin",
                            Status = "Active"
                        });
                });

            modelBuilder.Entity("MyFirstAPI.Models.Employee", b =>
                {
                    b.HasOne("MyFirstAPI.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFirstAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Username");

                    b.Navigation("Department");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
