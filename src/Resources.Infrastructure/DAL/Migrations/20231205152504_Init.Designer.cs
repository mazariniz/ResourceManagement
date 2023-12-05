﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Resources.Infrastructure.DAL;

#nullable disable

namespace Resources.Infrastructure.DAL.Migrations
{
    [DbContext(typeof(ResourceManagementDbContext))]
    [Migration("20231205152504_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Resources.Core.Entities.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CancelDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Canceled")
                        .HasColumnType("bit");

                    b.Property<Guid?>("CancelerUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatorUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("Resources.Core.Entities.ResourceBlockade", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BlockadeDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("BlockadeDuration")
                        .HasColumnType("time");

                    b.Property<Guid>("BlockadeOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ReleasedOnPurpose")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ResourceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ResourceBlockades");
                });
#pragma warning restore 612, 618
        }
    }
}