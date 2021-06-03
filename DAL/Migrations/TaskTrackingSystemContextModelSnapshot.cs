﻿// <auto-generated />
using System;
using DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(TaskTrackingSystemContext))]
    partial class TaskTrackingSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime?>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("TaskPriority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 5, 19, 51, 50, 40, DateTimeKind.Local).AddTicks(9019),
                            Description = "Task1 description",
                            Name = "Task1",
                            ProjectId = 1,
                            TaskPriority = "Medium",
                            TaskStatus = "Open",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 6, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(97),
                            Description = "Task2 description",
                            Name = "Task2",
                            ProjectId = 1,
                            TaskPriority = "Low",
                            TaskStatus = "InProgress",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 3, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(124),
                            Description = "Task3 description",
                            Name = "Task3",
                            ProjectId = 1,
                            TaskPriority = "High",
                            TaskStatus = "Completed",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 8, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(129),
                            Description = "Task4 description",
                            Name = "Task4",
                            ProjectId = 1,
                            TaskPriority = "Medium",
                            TaskStatus = "InProgress",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 4, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(132),
                            Description = "Task5 description",
                            Name = "Task5",
                            ProjectId = 1,
                            TaskPriority = "Low",
                            TaskStatus = "Open",
                            UserId = 2
                        },
                        new
                        {
                            Id = 6,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 6, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(135),
                            Description = "Task6 description",
                            Name = "Task6",
                            ProjectId = 1,
                            TaskPriority = "High",
                            TaskStatus = "Completed",
                            UserId = 2
                        },
                        new
                        {
                            Id = 7,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 5, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(138),
                            Description = "Task7 description",
                            Name = "Task7",
                            ProjectId = 1,
                            TaskPriority = "Medium",
                            TaskStatus = "Open",
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 7, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(141),
                            Description = "Task8 description",
                            Name = "Task8",
                            ProjectId = 1,
                            TaskPriority = "Critical",
                            TaskStatus = "Open",
                            UserId = 2
                        },
                        new
                        {
                            Id = 9,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 3, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(144),
                            Description = "Task9 description",
                            Name = "Task9",
                            ProjectId = 1,
                            TaskPriority = "Critical",
                            TaskStatus = "InProgress",
                            UserId = 2
                        },
                        new
                        {
                            Id = 10,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 5, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(147),
                            Description = "Task10 description",
                            Name = "Task10",
                            ProjectId = 1,
                            TaskPriority = "Low",
                            TaskStatus = "OnHold",
                            UserId = 1
                        },
                        new
                        {
                            Id = 11,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 8, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(150),
                            Description = "Task11 description",
                            Name = "Task11",
                            ProjectId = 1,
                            TaskPriority = "Medium",
                            TaskStatus = "Cancelled",
                            UserId = 2
                        },
                        new
                        {
                            Id = 12,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2021, 6, 6, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(153),
                            Description = "Task12 description",
                            Name = "Task12",
                            ProjectId = 1,
                            TaskPriority = "High",
                            TaskStatus = "InProgress",
                            UserId = 1
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
                            ConcurrencyStamp = "b7d96405-e666-4e8e-8e5f-0c5eac1f70d6",
                            Email = "vladimir231200@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Vladimir",
                            LockoutEnabled = false,
                            NormalizedEmail = "VLADIMIR231200@GMAIL.COM",
                            NormalizedUserName = "UGRDTR",
                            PasswordHash = "AQAAAAEAACcQAAAAEIDxKI1D+ruPw/tn9QLdkFIhZM27JAUF3xywRRJxM6fdxtlQyLLfeQ7UuRt6gAHMaw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "87f15177-8808-4d1f-88fc-a4ee8a8b8c3c",
                            Surname = "Shengeliya",
                            TwoFactorEnabled = false,
                            UserName = "ugrdtr"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c2fdb2c5-7358-4438-80ca-c41d91a74328",
                            Email = "ns18091@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nikita",
                            LockoutEnabled = false,
                            NormalizedEmail = "NS18091@GMAIL.COM",
                            NormalizedUserName = "MXXNR1SE",
                            PasswordHash = "AQAAAAEAACcQAAAAEMwMnVT+f6Q4cUcJokWftjk0EY2+wbw82fQfGu+CJ39ffhAxJiuuJX7FVB640tOYQw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "86da9f1d-b2c6-40c4-a9c2-b6a58cc89d81",
                            Surname = "Sidorov",
                            TwoFactorEnabled = false,
                            UserName = "mxxnr1se"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6e2c326e-a6ab-4f77-a225-4980964cf51d",
                            Email = "kochka4real@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Danila",
                            LockoutEnabled = false,
                            NormalizedEmail = "KOCHKA4REAL@GMAIL.COM",
                            NormalizedUserName = "AOLAN13",
                            PasswordHash = "AQAAAAEAACcQAAAAEMhiP50mvLm3VQ/RbMm/fuHlg8E5+730KqT3mc7Ls8g/CkDBjqsKNBZ3M9E13ayY8w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8b9a1730-d8cd-40b2-865c-e74453101c09",
                            Surname = "Crazy",
                            TwoFactorEnabled = false,
                            UserName = "Aolan13"
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "659e7079-efb4-431c-9f72-60d0adff286e",
                            Email = "janglaide@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Alison",
                            LockoutEnabled = false,
                            NormalizedEmail = "JANGLAIDE@GMAIL.COM",
                            NormalizedUserName = "JANGLAIDE",
                            PasswordHash = "AQAAAAEAACcQAAAAEMjOTxMuuI+PmbFMIJpY7BHe2MZ+iYDh5EzPOeFpbiQBu1bxa3R41u2GNqeMpRLFSw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "16f4c40b-75e0-4820-a406-ddcf48f34b78",
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
                            ConcurrencyStamp = "ee53d2c9-6d3f-401b-b596-c436e66c44b8",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "71580b31-9d26-4807-b8c9-76e58ef97e1b",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "4c0f9a3f-cc5b-48b7-a1d7-6d446065cbe6",
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

            modelBuilder.Entity("UsersProjects", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersProjects");

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
                    b.HasOne("DAL.Entities.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
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

            modelBuilder.Entity("UsersProjects", b =>
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

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
