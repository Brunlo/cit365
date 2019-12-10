﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(WebApplication1Context))]
    [Migration("20190703182933_intial")]
    partial class intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Delivery", b =>
                {
                    b.Property<int>("DeliveryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Days");

                    b.Property<string>("RushOrderDay");

                    b.HasKey("DeliveryID");

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("WebApplication1.Models.Desk", b =>
                {
                    b.Property<int>("DeskID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Depth");

                    b.Property<int>("MaterialID");

                    b.Property<int>("NumDrawers");

                    b.Property<int>("Width");

                    b.HasKey("DeskID");

                    b.HasIndex("MaterialID");

                    b.ToTable("Desk");
                });

            modelBuilder.Entity("WebApplication1.Models.DeskQuote", b =>
                {
                    b.Property<int>("DeskQuoteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName");

                    b.Property<int>("DeliveryID");

                    b.Property<int>("DeskID");

                    b.Property<decimal>("DeskPrice");

                    b.Property<DateTime>("QuoteDate");

                    b.Property<decimal>("ShippingCost");

                    b.HasKey("DeskQuoteID");

                    b.HasIndex("DeliveryID");

                    b.HasIndex("DeskID");

                    b.ToTable("DeskQuote");
                });

            modelBuilder.Entity("WebApplication1.Models.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaterialType");

                    b.Property<decimal>("Price");

                    b.HasKey("MaterialId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("WebApplication1.Models.Desk", b =>
                {
                    b.HasOne("WebApplication1.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.DeskQuote", b =>
                {
                    b.HasOne("WebApplication1.Models.Delivery", "Delivery")
                        .WithMany()
                        .HasForeignKey("DeliveryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Desk", "Desk")
                        .WithMany()
                        .HasForeignKey("DeskID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
