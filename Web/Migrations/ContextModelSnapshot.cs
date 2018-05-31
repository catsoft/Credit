﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Web.Models;

namespace Web.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Web.Models.AvialableCredit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BankName");

                    b.Property<DateTime>("DateCreated");

                    b.Property<float>("MaxAmount");

                    b.Property<int>("MaxDuration");

                    b.Property<float>("Percent");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("AvialableCredits");
                });

            modelBuilder.Entity("Web.Models.CmsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("IsSinglePage");

                    b.Property<int>("NewCount");

                    b.Property<int>("Position");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("CmsModels");
                });

            modelBuilder.Entity("Web.Models.Credit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Amount");

                    b.Property<string>("BankName");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("DurationInMonth");

                    b.Property<bool>("IsPay");

                    b.Property<string>("ListPayment");

                    b.Property<string>("Name");

                    b.Property<float>("Procent");

                    b.Property<float>("Rest");

                    b.Property<DateTime>("StartCredit");

                    b.Property<string>("Title");

                    b.Property<string>("TypeCredit");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("Web.Models.FileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FileType");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Web.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Extension");

                    b.Property<string>("ImageType");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Web.Models.TokenModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Title");

                    b.Property<string>("Token");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TokenModels");
                });

            modelBuilder.Entity("Web.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("SecondName");

                    b.Property<string>("Town");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Web.Models.Credit", b =>
                {
                    b.HasOne("Web.Models.User", "User")
                        .WithMany("Credits")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.TokenModel", b =>
                {
                    b.HasOne("Web.Models.User", "User")
                        .WithMany("TokenModels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
