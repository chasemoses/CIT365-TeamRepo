// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMDesigner.Data;

namespace SMDesigner.Migrations
{
    [DbContext(typeof(ProgramContext))]
    [Migration("20221207043840_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SMDesigner.Models.SacramentProgram", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClosePrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CloseSong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConductorL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntermedNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpenPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpenSong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProgramDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SacramentSong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpeakerFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SacramentProgram");
                });
#pragma warning restore 612, 618
        }
    }
}
