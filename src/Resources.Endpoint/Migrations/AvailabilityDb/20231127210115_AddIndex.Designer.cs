﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Resources.Endpoint.Availabaility.Domain.DbContexts;

#nullable disable

namespace Resources.Endpoint.Migrations.AvailabilityDb
{
    [DbContext(typeof(AvailabilityDbContext))]
    [Migration("20231127210115_AddIndex")]
    partial class AddIndex
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Availability")
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Resources.Endpoint.Availabaility.Domain.Models.ResourceBlockade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BlockadeDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("BlockadeDuration")
                        .HasColumnType("time");

                    b.Property<Guid>("BlockadeOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ReleasedOnPurpose")
                        .HasColumnType("bit");

                    b.Property<Guid>("ResourceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.ToTable("ResourceBlockades", "Availability");
                });
#pragma warning restore 612, 618
        }
    }
}