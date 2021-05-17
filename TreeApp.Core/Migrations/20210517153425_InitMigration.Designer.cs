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
    [Migration("20210517153425_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TreeApp.Core.Models.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("TreeApp.Core.Models.Tree", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("ItemLevel")
                        .HasColumnType("int");

                    b.Property<int?>("ItemParent")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ItemID");

                    b.ToTable("Tree");
                });

            modelBuilder.Entity("TreeApp.Core.Models.Tree", b =>
                {
                    b.HasOne("TreeApp.Core.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID");
                });
#pragma warning restore 612, 618
        }
    }
}