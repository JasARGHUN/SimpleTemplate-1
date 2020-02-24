﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleTemplate_1.Models;

namespace SimpleTemplate_1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200214065020_T-4")]
    partial class T4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimpleTemplate_1.Models.Info", b =>
                {
                    b.Property<int>("InfoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppBackgroundImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppHomeImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppHomeText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppPhone1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppPhone2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppSocialAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppSocialImg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InfoID");

                    b.ToTable("Infos");
                });

            modelBuilder.Entity("SimpleTemplate_1.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
