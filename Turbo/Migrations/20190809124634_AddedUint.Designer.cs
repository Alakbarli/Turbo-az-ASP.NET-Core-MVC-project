﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Turbo.DAL;

namespace Turbo.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20190809124634_AddedUint")]
    partial class AddedUint
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Turbo.Models.BanNovu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("BanNovleri");

                    b.HasData(
                        new { Id = 1, Name = "Avtobus" },
                        new { Id = 2, Name = "Furqon" },
                        new { Id = 3, Name = "Hetcbek" },
                        new { Id = 4, Name = "Kupe" },
                        new { Id = 5, Name = "Motosiklet" },
                        new { Id = 6, Name = "SUV" },
                        new { Id = 7, Name = "Pikap" },
                        new { Id = 8, Name = "Sedan" },
                        new { Id = 9, Name = "Van" }
                    );
                });

            modelBuilder.Entity("Turbo.Models.Elan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BanNovuId");

                    b.Property<int>("IstehsalIliId");

                    b.Property<string>("Melumat")
                        .IsRequired();

                    b.Property<int>("ModelId");

                    b.Property<long>("MuherrikGucu");

                    b.Property<int>("MuherrikHecmiId");

                    b.Property<int>("OturucuId");

                    b.Property<decimal>("Qiymet");

                    b.Property<bool>("Register");

                    b.Property<int>("RengId");

                    b.Property<int>("SeherId");

                    b.Property<int>("SekilId");

                    b.Property<int>("SuretQutusuId");

                    b.Property<string>("UserId");

                    b.Property<bool>("Vip");

                    b.Property<int>("YanacaqNovuId");

                    b.Property<DateTime>("YazilmaVaxti");

                    b.Property<long>("YurusMesafesi");

                    b.HasKey("Id");

                    b.HasIndex("BanNovuId");

                    b.HasIndex("IstehsalIliId");

                    b.HasIndex("ModelId");

                    b.HasIndex("MuherrikHecmiId");

                    b.HasIndex("OturucuId");

                    b.HasIndex("RengId");

                    b.HasIndex("SeherId");

                    b.HasIndex("SuretQutusuId");

                    b.HasIndex("UserId");

                    b.HasIndex("YanacaqNovuId");

                    b.ToTable("Elanlar");
                });

            modelBuilder.Entity("Turbo.Models.IstehsalIli", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Il");

                    b.HasKey("Id");

                    b.ToTable("IstehsalIlleri");
                });

            modelBuilder.Entity("Turbo.Models.Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Markalar");

                    b.HasData(
                        new { Id = 1, Name = "Nissan" },
                        new { Id = 2, Name = "Hyundai" },
                        new { Id = 3, Name = "Vaz" },
                        new { Id = 4, Name = "Dodge" },
                        new { Id = 5, Name = "Audi" },
                        new { Id = 6, Name = "BMW" },
                        new { Id = 7, Name = "Opel" },
                        new { Id = 8, Name = "Mercedes" }
                    );
                });

            modelBuilder.Entity("Turbo.Models.Meqale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Basliq")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Melumat")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.Property<string>("Sekil");

                    b.Property<string>("UserId");

                    b.Property<DateTime>("YazilmaVaxti");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Meqaleler");
                });

            modelBuilder.Entity("Turbo.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MarkaId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("MarkaId");

                    b.ToTable("Modeller");

                    b.HasData(
                        new { Id = 1, MarkaId = 1, Name = "GTR R-35" },
                        new { Id = 2, MarkaId = 1, Name = "GTR R-34" },
                        new { Id = 3, MarkaId = 1, Name = "Altima" },
                        new { Id = 4, MarkaId = 1, Name = "Petrol" },
                        new { Id = 5, MarkaId = 2, Name = "Elantra" },
                        new { Id = 6, MarkaId = 2, Name = "Azera" },
                        new { Id = 7, MarkaId = 2, Name = "Coupe" },
                        new { Id = 8, MarkaId = 2, Name = "Sonata" },
                        new { Id = 9, MarkaId = 3, Name = "Priora" },
                        new { Id = 10, MarkaId = 3, Name = "Niva" },
                        new { Id = 11, MarkaId = 3, Name = "2106" },
                        new { Id = 12, MarkaId = 3, Name = "2107" },
                        new { Id = 13, MarkaId = 3, Name = "2108" },
                        new { Id = 14, MarkaId = 4, Name = "Challenger" },
                        new { Id = 15, MarkaId = 4, Name = "Charger" },
                        new { Id = 16, MarkaId = 4, Name = "Dart" },
                        new { Id = 17, MarkaId = 4, Name = "Durango" },
                        new { Id = 18, MarkaId = 4, Name = "Nitro" },
                        new { Id = 19, MarkaId = 4, Name = "Stratus" },
                        new { Id = 20, MarkaId = 5, Name = "A4" },
                        new { Id = 21, MarkaId = 5, Name = "A4" },
                        new { Id = 22, MarkaId = 5, Name = "A6" },
                        new { Id = 23, MarkaId = 5, Name = "Q7" },
                        new { Id = 24, MarkaId = 5, Name = "Q8" },
                        new { Id = 25, MarkaId = 5, Name = "TTS" },
                        new { Id = 26, MarkaId = 6, Name = "525" },
                        new { Id = 27, MarkaId = 6, Name = "650" },
                        new { Id = 28, MarkaId = 6, Name = "750" },
                        new { Id = 29, MarkaId = 6, Name = "M3" },
                        new { Id = 30, MarkaId = 6, Name = "M4" },
                        new { Id = 31, MarkaId = 6, Name = "M5" },
                        new { Id = 32, MarkaId = 6, Name = "X5" },
                        new { Id = 33, MarkaId = 6, Name = "X6" },
                        new { Id = 34, MarkaId = 6, Name = "Z4" },
                        new { Id = 35, MarkaId = 7, Name = "Astra" },
                        new { Id = 36, MarkaId = 7, Name = "Combo" },
                        new { Id = 37, MarkaId = 7, Name = "Corsa" },
                        new { Id = 38, MarkaId = 7, Name = "Omega" },
                        new { Id = 39, MarkaId = 7, Name = "Vita" },
                        new { Id = 41, MarkaId = 7, Name = "Zafira" },
                        new { Id = 42, MarkaId = 8, Name = "190" },
                        new { Id = 43, MarkaId = 8, Name = "200" },
                        new { Id = 44, MarkaId = 8, Name = "A200" },
                        new { Id = 45, MarkaId = 8, Name = "B200" },
                        new { Id = 46, MarkaId = 8, Name = "C200" },
                        new { Id = 47, MarkaId = 8, Name = "AMG GT" },
                        new { Id = 48, MarkaId = 8, Name = "GLK-320" },
                        new { Id = 49, MarkaId = 8, Name = "ML 500" },
                        new { Id = 50, MarkaId = 8, Name = "S 500" }
                    );
                });

            modelBuilder.Entity("Turbo.Models.MuherrikHecmi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Hecm");

                    b.HasKey("Id");

                    b.ToTable("MuherrikHecmleri");

                    b.HasData(
                        new { Id = 1, Hecm = 100 },
                        new { Id = 2, Hecm = 200 },
                        new { Id = 3, Hecm = 300 },
                        new { Id = 4, Hecm = 400 },
                        new { Id = 5, Hecm = 500 },
                        new { Id = 6, Hecm = 600 },
                        new { Id = 7, Hecm = 700 },
                        new { Id = 8, Hecm = 800 },
                        new { Id = 9, Hecm = 900 },
                        new { Id = 10, Hecm = 1000 },
                        new { Id = 11, Hecm = 1200 },
                        new { Id = 12, Hecm = 1500 },
                        new { Id = 13, Hecm = 2000 },
                        new { Id = 14, Hecm = 3000 },
                        new { Id = 15, Hecm = 5000 },
                        new { Id = 16, Hecm = 6000 },
                        new { Id = 17, Hecm = 9000 },
                        new { Id = 18, Hecm = 10000 },
                        new { Id = 19, Hecm = 15000 }
                    );
                });

            modelBuilder.Entity("Turbo.Models.Oturucu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Oturuculer");

                    b.HasData(
                        new { Id = 1, Name = "Arxa" },
                        new { Id = 2, Name = "On" },
                        new { Id = 3, Name = "Tam" }
                    );
                });

            modelBuilder.Entity("Turbo.Models.Reng", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Rengler");

                    b.HasData(
                        new { Id = 1, Name = "Ag" },
                        new { Id = 2, Name = "Qara" },
                        new { Id = 3, Name = "Qehveyi" },
                        new { Id = 4, Name = "Yasil" },
                        new { Id = 5, Name = "Goy" },
                        new { Id = 6, Name = "Qirmizi" },
                        new { Id = 7, Name = "Cehrayi" },
                        new { Id = 8, Name = "Boz" },
                        new { Id = 9, Name = "Qizili" },
                        new { Id = 10, Name = "Gumusu" },
                        new { Id = 11, Name = "Sari" }
                    );
                });

            modelBuilder.Entity("Turbo.Models.Seher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Seherler");

                    b.HasData(
                        new { Id = 1, Name = "Baki" },
                        new { Id = 2, Name = "Semkir" },
                        new { Id = 3, Name = "Gence" },
                        new { Id = 4, Name = "Qazax" },
                        new { Id = 5, Name = "Qax" },
                        new { Id = 6, Name = "Astara" }
                    );
                });

            modelBuilder.Entity("Turbo.Models.Sekil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ElanId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ElanId");

                    b.ToTable("Sekiller");
                });

            modelBuilder.Entity("Turbo.Models.SuretQutusu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("SuretlerQutusu");

                    b.HasData(
                        new { Id = 1, Name = "Avtomatik" },
                        new { Id = 2, Name = "Mexaniki" },
                        new { Id = 3, Name = "Yari-Avtomatik" }
                    );
                });

            modelBuilder.Entity("Turbo.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Turbo.Models.YanacaqNovu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("YanacaqNovleri");

                    b.HasData(
                        new { Id = 1, Name = "Benzin" },
                        new { Id = 2, Name = "Dizel" },
                        new { Id = 3, Name = "Qaz" },
                        new { Id = 4, Name = "Hibrid" },
                        new { Id = 5, Name = "Elektrik" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Turbo.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Turbo.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Turbo.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Turbo.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Turbo.Models.Elan", b =>
                {
                    b.HasOne("Turbo.Models.BanNovu", "BanNovu")
                        .WithMany("Elanlar")
                        .HasForeignKey("BanNovuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Turbo.Models.IstehsalIli", "IstehsalIli")
                        .WithMany("Elanlar")
                        .HasForeignKey("IstehsalIliId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Turbo.Models.Model", "Model")
                        .WithMany("Elanlar")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Turbo.Models.MuherrikHecmi", "MuherrikHecmi")
                        .WithMany("Elanlar")
                        .HasForeignKey("MuherrikHecmiId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Turbo.Models.Oturucu", "Oturucu")
                        .WithMany("Elanlar")
                        .HasForeignKey("OturucuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Turbo.Models.Reng", "Reng")
                        .WithMany("Elanlar")
                        .HasForeignKey("RengId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Turbo.Models.Seher", "Seher")
                        .WithMany("Elanlar")
                        .HasForeignKey("SeherId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Turbo.Models.SuretQutusu", "SuretQutusu")
                        .WithMany()
                        .HasForeignKey("SuretQutusuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Turbo.Models.User", "User")
                        .WithMany("Elanlar")
                        .HasForeignKey("UserId");

                    b.HasOne("Turbo.Models.YanacaqNovu", "YanacaqNovu")
                        .WithMany("Elanlar")
                        .HasForeignKey("YanacaqNovuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Turbo.Models.Meqale", b =>
                {
                    b.HasOne("Turbo.Models.User", "User")
                        .WithMany("Meqaleler")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Turbo.Models.Model", b =>
                {
                    b.HasOne("Turbo.Models.Marka", "Marka")
                        .WithMany("Models")
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Turbo.Models.Sekil", b =>
                {
                    b.HasOne("Turbo.Models.Elan", "Elan")
                        .WithMany("Sekiller")
                        .HasForeignKey("ElanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
