// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesMarketing.Infrastructure.Context;

#nullable disable

namespace SalesMarketing.Infrastructure.Migrations
{
    [DbContext(typeof(SalesMarketingContext))]
    [Migration("20211221054328_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SalesMarketing.Domain.MasterBarang", b =>
                {
                    b.Property<Guid>("MasterBarangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Bbn")
                        .HasColumnType("money");

                    b.Property<decimal?>("HargaOff")
                        .HasColumnType("money");

                    b.Property<string>("KapasitasMesin")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<int>("MasterBarangStatus")
                        .HasColumnType("int");

                    b.Property<string>("Merek")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NamaBarang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoUrutId"), 1L, 1);

                    b.Property<string>("NomorMesin")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NomorRangka")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TahunPerakitan")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("TypeKendaraan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("MasterBarangId");

                    b.ToTable("MasterBarang", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
