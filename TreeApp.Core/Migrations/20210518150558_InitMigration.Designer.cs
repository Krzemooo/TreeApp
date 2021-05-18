﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TreeApp.Core;

namespace TreeApp.Core.Migrations
{
    [DbContext(typeof(DBCoreContext))]
    [Migration("20210518150558_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TreeApp.Core.Models.Tree", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemLevel")
                        .HasColumnType("int");

                    b.Property<int>("ItemPosition")
                        .HasColumnType("int");

                    b.Property<string>("ItemValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentUniqID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UniqItemID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("Tree");
                });
#pragma warning restore 612, 618
        }
    }
}