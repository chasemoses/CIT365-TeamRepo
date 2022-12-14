// <auto-generated />
using System;
using Mega_Desk_Web_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mega_Desk_Web_App.Migrations
{
    [DbContext(typeof(Mega_Desk_Web_AppContext))]
    [Migration("20221102043815_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mega_Desk_Web_App.Models.Quote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CustName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Depth")
                        .HasColumnType("int");

                    b.Property<int>("Drawers")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Production")
                        .HasColumnType("int");

                    b.Property<DateTime>("QuoteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Quote");
                });
#pragma warning restore 612, 618
        }
    }
}
