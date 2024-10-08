﻿// <auto-generated />
using AspireApp2.ApiService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AspireApp2.ApiService.Migrations
{
    [DbContext(typeof(SampleDbContext))]
    [Migration("20240905144835_AddAFreshTable")]
    partial class AddAFreshTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AspireApp2.ApiService.Data.SampleData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AfterInitBool")
                        .HasColumnType("boolean");

                    b.Property<bool>("AfterInitBoolWithAttributes")
                        .HasColumnType("boolean");

                    b.Property<bool>("AfterInitBoolWithDefaultValueAttribute")
                        .HasColumnType("boolean");

                    b.Property<bool>("InitBool")
                        .HasColumnType("boolean");

                    b.Property<bool>("InitBoolWithAttributes")
                        .HasColumnType("boolean");

                    b.Property<bool>("InitBoolWithDefaultValueAttribute")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("SampleData");
                });

            modelBuilder.Entity("AspireApp2.ApiService.Data.SampleNewTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AfterInitBool")
                        .HasColumnType("boolean");

                    b.Property<bool>("AfterInitBoolWithAttributes")
                        .HasColumnType("boolean");

                    b.Property<bool>("AfterInitBoolWithDefaultValueAttribute")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("SampleNewTables");
                });
#pragma warning restore 612, 618
        }
    }
}
