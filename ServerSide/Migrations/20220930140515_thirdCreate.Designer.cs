﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerSide.Data;

#nullable disable

namespace ServerSide.Migrations
{
    [DbContext(typeof(CollegeContext))]
    [Migration("20220930140515_thirdCreate")]
    partial class thirdCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ServerSide.Models.Average", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("courseNum")
                        .HasColumnType("int");

                    b.Property<double>("average")
                        .HasColumnType("float");

                    b.HasKey("StudentID", "courseNum");

                    b.ToTable("Averages");
                });

            modelBuilder.Entity("ServerSide.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"), 1L, 1);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseNum")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ServerSide.Models.Enrolment", b =>
                {
                    b.Property<int>("EnrolmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrolmentID"), 1L, 1);

                    b.Property<int>("CourseNum")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("EnrolmentID");

                    b.ToTable("Enrolments");
                });

            modelBuilder.Entity("ServerSide.Models.Grade", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("CourseNum")
                        .HasColumnType("int");

                    b.Property<int>("TaskNum")
                        .HasColumnType("int");

                    b.Property<int>("GradeID")
                        .HasColumnType("int");

                    b.Property<int>("grade")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "CourseNum", "TaskNum");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("ServerSide.Models.Task", b =>
                {
                    b.Property<int>("TaskNum")
                        .HasColumnType("int");

                    b.Property<int>("CourseNum")
                        .HasColumnType("int");

                    b.Property<string>("JsonFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleFile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskNum", "CourseNum");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("ServerSide.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("role")
                        .HasColumnType("int");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
