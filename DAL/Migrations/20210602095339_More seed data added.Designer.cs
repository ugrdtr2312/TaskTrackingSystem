﻿// <auto-generated />
using System;
using DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(TaskTrackingSystemContext))]
    [Migration("20210602095339_More seed data added")]
    partial class Moreseeddataadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Web project 1 description",
                            Name = "Web project 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Web project 2 description",
                            Name = "Web project 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Web project 3 description",
                            Name = "Web project 3"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("TaskPriorityId")
                        .HasColumnType("int");

                    b.Property<int>("TaskStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TaskPriorityId");

                    b.HasIndex("TaskStatusId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 5, 12, 53, 39, 88, DateTimeKind.Local).AddTicks(3631),
                            Description = "Task1 description",
                            EmployeeId = 1,
                            Name = "Task1",
                            ProjectId = 1,
                            TaskPriorityId = 2,
                            TaskStatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 6, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5464),
                            Description = "Task2 description",
                            EmployeeId = 1,
                            Name = "Task2",
                            ProjectId = 1,
                            TaskPriorityId = 1,
                            TaskStatusId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 3, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5541),
                            Description = "Task3 description",
                            EmployeeId = 1,
                            Name = "Task3",
                            ProjectId = 1,
                            TaskPriorityId = 3,
                            TaskStatusId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 8, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5548),
                            Description = "Task4 description",
                            EmployeeId = 1,
                            Name = "Task4",
                            ProjectId = 1,
                            TaskPriorityId = 2,
                            TaskStatusId = 2
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 4, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5551),
                            Description = "Task5 description",
                            EmployeeId = 2,
                            Name = "Task5",
                            ProjectId = 1,
                            TaskPriorityId = 1,
                            TaskStatusId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 6, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5555),
                            Description = "Task6 description",
                            EmployeeId = 2,
                            Name = "Task6",
                            ProjectId = 1,
                            TaskPriorityId = 3,
                            TaskStatusId = 3
                        },
                        new
                        {
                            Id = 7,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 5, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5558),
                            Description = "Task7 description",
                            EmployeeId = 1,
                            Name = "Task7",
                            ProjectId = 1,
                            TaskPriorityId = 2,
                            TaskStatusId = 1
                        },
                        new
                        {
                            Id = 8,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 7, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5561),
                            Description = "Task8 description",
                            EmployeeId = 2,
                            Name = "Task8",
                            ProjectId = 1,
                            TaskPriorityId = 4,
                            TaskStatusId = 1
                        },
                        new
                        {
                            Id = 9,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 3, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5564),
                            Description = "Task9 description",
                            EmployeeId = 2,
                            Name = "Task9",
                            ProjectId = 1,
                            TaskPriorityId = 4,
                            TaskStatusId = 2
                        },
                        new
                        {
                            Id = 10,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 5, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5567),
                            Description = "Task10 description",
                            EmployeeId = 1,
                            Name = "Task10",
                            ProjectId = 1,
                            TaskPriorityId = 1,
                            TaskStatusId = 5
                        },
                        new
                        {
                            Id = 11,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 8, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5570),
                            Description = "Task11 description",
                            EmployeeId = 2,
                            Name = "Task11",
                            ProjectId = 1,
                            TaskPriorityId = 2,
                            TaskStatusId = 4
                        },
                        new
                        {
                            Id = 12,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 6, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5572),
                            Description = "Task12 description",
                            EmployeeId = 1,
                            Name = "Task12",
                            ProjectId = 1,
                            TaskPriorityId = 3,
                            TaskStatusId = 2
                        });
                });

            modelBuilder.Entity("DAL.Entities.TaskPriority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TaskPriority");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Low"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            Name = "High"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Critical"
                        });
                });

            modelBuilder.Entity("DAL.Entities.TaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TaskStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Open"
                        },
                        new
                        {
                            Id = 2,
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Completed"
                        },
                        new
                        {
                            Id = 4,
                            Name = "On Hold"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cancelled"
                        });
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5c908388-4394-41df-90a8-d1d59ce66aea",
                            Email = "vladimir231200@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Vladimir",
                            LockoutEnabled = false,
                            NormalizedEmail = "VLADIMIR231200@GMAIL.COM",
                            NormalizedUserName = "UGRDTR",
                            PasswordHash = "AQAAAAEAACcQAAAAELvkcjyDCdJHoMZ6C14BiH5EP6PUzyoYg/xIgxL91KkKr85LGQBXcEHMMI6kJ6FTpw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "367eb21f-b499-45ee-a596-c834da8121c0",
                            Surname = "Shengeliya",
                            TwoFactorEnabled = false,
                            UserName = "ugrdtr"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4330ae7a-0696-47fa-a1c8-d88462376601",
                            Email = "ns18091@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nikita",
                            LockoutEnabled = false,
                            NormalizedEmail = "NS18091@GMAIL.COM",
                            NormalizedUserName = "MXXNR1SE",
                            PasswordHash = "AQAAAAEAACcQAAAAEJZrVJ6Ma/8pjNpBjh3DKwZkNO0C6yoYUxhLizwF9NzLMmvCiT+F1mfmlJ/EzJEF5w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d2946575-9004-4bb9-b11a-333c3db1bf75",
                            Surname = "Sidorov",
                            TwoFactorEnabled = false,
                            UserName = "mxxnr1se"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2c241cfd-9661-4da2-abce-959cba35666b",
                            Email = "kochka4real@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Danila",
                            LockoutEnabled = false,
                            NormalizedEmail = "KOCHKA4REAL@GMAIL.COM",
                            NormalizedUserName = "AOLAN13",
                            PasswordHash = "AQAAAAEAACcQAAAAEJnywSRN42MlFs+3wzI7+U9d/X6azm1UKGFUam8FewNAv1zJJOBJmi4hbYVwFNdglA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "beec1df3-db36-4a36-ae16-495d512d713a",
                            Surname = "Crazy",
                            TwoFactorEnabled = false,
                            UserName = "Aolan13"
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0d83f52d-b225-41e7-b2d7-2bf61b3f8f26",
                            Email = "janglaide@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Alison",
                            LockoutEnabled = false,
                            NormalizedEmail = "JANGLAIDE@GMAIL.COM",
                            NormalizedUserName = "JANGLAIDE",
                            PasswordHash = "AQAAAAEAACcQAAAAEOZO+n7JYc+mFwxmosut4ylI2oP/mSowLh2E0+OCtDIFKJLUfkAGIFwK+cSbVX+CmA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f2418e35-35cb-4d6f-a6b5-ebaac4d3f85e",
                            Surname = "Proshchenko",
                            TwoFactorEnabled = false,
                            UserName = "janglaide"
                        });
                });

            modelBuilder.Entity("DAL.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "59c24955-a469-4c67-a4a8-2911b22fce44",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "f5876f4a-4558-44d6-8de3-87fa1bbc52b6",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "333179e6-9668-4571-aec3-45d2626ae6a8",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UserProject", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserProject");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            UserId = 1
                        },
                        new
                        {
                            ProjectId = 1,
                            UserId = 2
                        },
                        new
                        {
                            ProjectId = 1,
                            UserId = 3
                        },
                        new
                        {
                            ProjectId = 2,
                            UserId = 1
                        },
                        new
                        {
                            ProjectId = 2,
                            UserId = 2
                        },
                        new
                        {
                            ProjectId = 2,
                            UserId = 3
                        },
                        new
                        {
                            ProjectId = 3,
                            UserId = 1
                        },
                        new
                        {
                            ProjectId = 3,
                            UserId = 2
                        },
                        new
                        {
                            ProjectId = 3,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("DAL.Entities.Task", b =>
                {
                    b.HasOne("DAL.Entities.User", "Employee")
                        .WithMany("Tasks")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAL.Entities.TaskPriority", "TaskPriority")
                        .WithMany("Tasks")
                        .HasForeignKey("TaskPriorityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAL.Entities.TaskStatus", "TaskStatus")
                        .WithMany("Tasks")
                        .HasForeignKey("TaskStatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");

                    b.Navigation("TaskPriority");

                    b.Navigation("TaskStatus");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("DAL.Entities.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("DAL.Entities.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UserProject", b =>
                {
                    b.HasOne("DAL.Entities.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.Project", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("DAL.Entities.TaskPriority", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("DAL.Entities.TaskStatus", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
