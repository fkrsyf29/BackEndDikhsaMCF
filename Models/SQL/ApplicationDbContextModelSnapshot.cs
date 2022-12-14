// <auto-generated />
using System;
using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackEnd.Models.SQL
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BackEnd.Models.Ms_Storage_Location", b =>
                {
                    b.Property<string>("location_id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("location_name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("location_id");

                    b.ToTable("Ms_Storage_Locations");

                    b.HasData(
                        new
                        {
                            location_id = "3201210001",
                            location_name = "Karadenan"
                        },
                        new
                        {
                            location_id = "3201210002",
                            location_name = "Nanggewer"
                        },
                        new
                        {
                            location_id = "3201210003",
                            location_name = "Nanggewer Mekar"
                        },
                        new
                        {
                            location_id = "3201210004",
                            location_name = "Cibinong"
                        },
                        new
                        {
                            location_id = "3201210005",
                            location_name = "Pakansari"
                        });
                });

            modelBuilder.Entity("BackEnd.Models.Tr_Bpkb", b =>
                {
                    b.Property<string>("agreement_number")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("bpkb_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("bpkb_date_in")
                        .HasColumnType("datetime2");

                    b.Property<string>("bpkb_no")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("branch_id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("faktur_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("faktur_no")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("location_id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("police_no")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("agreement_number");

                    b.HasIndex("location_id");

                    b.ToTable("Tr_Bpkbs");
                });

            modelBuilder.Entity("BackEnd.Models.Tr_Bpkb", b =>
                {
                    b.HasOne("BackEnd.Models.Ms_Storage_Location", null)
                        .WithMany()
                        .HasForeignKey("location_id");
                });
#pragma warning restore 612, 618
        }
    }
}
