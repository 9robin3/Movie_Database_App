﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movie_Database_App.Data;

namespace Movie_Database_App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211109124200_IdentityTweaks")]
    partial class IdentityTweaks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Movie_Database_App.Data.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("RoleInfo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Movie_Database_App.Data.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

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
                });

            modelBuilder.Entity("Movie_Database_App.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PosterUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("RunningTime")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2019),
                            Description = "desc",
                            Genre = "Action",
                            PosterUrl = "https://artiks.se/media/catalog/product/cache/1941e30f13ad4c84c12405c473c5cb3f/1/3/41688/47916/berlin-vintage-poster.jpg",
                            RunningTime = 200f,
                            Title = "test1",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 2,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc2",
                            Genre = "Scifi",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 70f,
                            Title = "test2",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 3,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2005),
                            Description = "desc3",
                            Genre = "Horror",
                            PosterUrl = "https://image.posterlounge.se/images/l/1892194.jpg",
                            RunningTime = 120f,
                            Title = "test3",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 4,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995),
                            Description = "desc4",
                            Genre = "Horror",
                            PosterUrl = "https://image.posterlounge.se/images/l/1892194.jpg",
                            RunningTime = 120f,
                            Title = "test4",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 5,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc5",
                            Genre = "Adventure",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 70f,
                            Title = "test5",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 6,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2019),
                            Description = "desc6",
                            Genre = "Action",
                            PosterUrl = "https://artiks.se/media/catalog/product/cache/1941e30f13ad4c84c12405c473c5cb3f/1/3/41688/47916/berlin-vintage-poster.jpg",
                            RunningTime = 200f,
                            Title = "test6",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 7,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc7",
                            Genre = "Scifi",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 70f,
                            Title = "test7",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 8,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc8",
                            Genre = "Adventure",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 320f,
                            Title = "test8",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 9,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc8",
                            Genre = "Adventure",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 320f,
                            Title = "test9",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 10,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc8",
                            Genre = "Adventure",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 320f,
                            Title = "test10",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 11,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc8",
                            Genre = "Adventure",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 320f,
                            Title = "test11",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 12,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc8",
                            Genre = "Scifi",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 320f,
                            Title = "test12",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 13,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc8",
                            Genre = "Horror",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 320f,
                            Title = "test13",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 14,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc8",
                            Genre = "Adventure",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 320f,
                            Title = "test14",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 15,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc8",
                            Genre = "Adventure",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 320f,
                            Title = "test15",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        },
                        new
                        {
                            MovieID = 16,
                            DatePublished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017),
                            Description = "desc8",
                            Genre = "Comedy",
                            PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg",
                            RunningTime = 320f,
                            Title = "test16",
                            TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment"
                        });
                });

            modelBuilder.Entity("Movie_Database_App.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MovieID1")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewID");

                    b.HasIndex("MovieID1");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Movie_Database_App.Data.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Movie_Database_App.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Movie_Database_App.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Movie_Database_App.Data.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movie_Database_App.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Movie_Database_App.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Movie_Database_App.Models.Review", b =>
                {
                    b.HasOne("Movie_Database_App.Models.Movie", null)
                        .WithMany("ReviewsList")
                        .HasForeignKey("MovieID1");
                });

            modelBuilder.Entity("Movie_Database_App.Models.Movie", b =>
                {
                    b.Navigation("ReviewsList");
                });
#pragma warning restore 612, 618
        }
    }
}
