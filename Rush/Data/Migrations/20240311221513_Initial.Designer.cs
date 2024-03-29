﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rush.Data;

#nullable disable

namespace Rush.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240311221513_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Rush.Data.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Filesname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("imagecover")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = new Guid("04d98ca9-7e8b-442f-b768-0dd727ff394e"),
                            Filesname = "CODBO2.rar",
                            LastUpdated = new DateOnly(2024, 3, 12),
                            Name = "Call Of Duty Black Ops 2",
                            imagecover = "cover.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
