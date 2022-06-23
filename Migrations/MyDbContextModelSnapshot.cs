﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zip2Clear.Data;

#nullable disable

namespace Zip2Clear.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Zip2Clear.Data.Declaration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("BOLnumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryOfDestination")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryOfOrigin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeclarationNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DeclarationOffice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Exporter")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Importer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ManifestNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModeOfTransport")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PortOfEntry")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PortOfExit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Regime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Submitted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SubmittedDate")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalGrossMassMeasureQnty")
                        .HasColumnType("REAL");

                    b.Property<string>("TotalGrossMassMeasureUOM")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalPackageQnty")
                        .HasColumnType("REAL");

                    b.Property<string>("TotalPackageQntyUOM")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Declaration");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7819b5af-e784-4723-927c-19084c303a1f"),
                            BOLnumber = "PEVMOB005095",
                            CountryOfDestination = "BS",
                            CountryOfOrigin = "US",
                            CreatedDate = new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6512),
                            DeclarationNumber = "2022DEC0000845484",
                            DeclarationOffice = "SAQPDK",
                            Exporter = "Mennonite Messianic Mission",
                            Importer = "Mennonite Messianic Mission",
                            ManifestNumber = "MSTRNO30613",
                            ModeOfTransport = "1",
                            PortOfEntry = "SAQ",
                            PortOfExit = "USPVS",
                            Regime = "4",
                            Status = "Compliance",
                            Submitted = true,
                            SubmittedDate = new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6514),
                            TotalGrossMassMeasureQnty = 390.0,
                            TotalGrossMassMeasureUOM = "LB",
                            TotalPackageQnty = 1.0,
                            TotalPackageQntyUOM = "EA",
                            Type = "400"
                        },
                        new
                        {
                            Id = new Guid("8d513ba9-4ca0-405d-919b-ce2f704cd200"),
                            BOLnumber = "PEVMOB005096",
                            CountryOfDestination = "BS",
                            CountryOfOrigin = "US",
                            CreatedDate = new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6522),
                            DeclarationNumber = "2022DEC0000845474",
                            DeclarationOffice = "SAQPDK",
                            Exporter = "Mennonite Messianic Mission",
                            Importer = "Mennonite Messianic Mission",
                            ManifestNumber = "MSTRNO30613",
                            ModeOfTransport = "1",
                            PortOfEntry = "SAQ",
                            PortOfExit = "USPVS",
                            Regime = "4",
                            Status = "Compliance",
                            Submitted = true,
                            SubmittedDate = new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6524),
                            TotalGrossMassMeasureQnty = 40.0,
                            TotalGrossMassMeasureUOM = "LB",
                            TotalPackageQnty = 1.0,
                            TotalPackageQntyUOM = "EA",
                            Type = "400"
                        });
                });

            modelBuilder.Entity("Zip2Clear.Data.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DeclarationId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("FreightValue")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("InsuranceValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("VendorId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeclarationId");

                    b.HasIndex("VendorId");

                    b.ToTable("Invoice");

                    b.HasData(
                        new
                        {
                            Id = new Guid("23f60462-01b9-4559-bfec-fc2155a04aef"),
                            Date = new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6444),
                            FreightValue = 0m,
                            InsuranceValue = 150m,
                            InvoiceNumber = "814184793"
                        },
                        new
                        {
                            Id = new Guid("e4251985-cd56-4bee-9fb1-b4b2e5144121"),
                            Date = new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6477),
                            FreightValue = 0m,
                            InsuranceValue = 0m,
                            InvoiceNumber = "2022ES7023"
                        },
                        new
                        {
                            Id = new Guid("252d0531-b07d-4938-ab1b-c5f034abcccc"),
                            Date = new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6480),
                            FreightValue = 0m,
                            InsuranceValue = 0m,
                            InvoiceNumber = "2022ES8200"
                        },
                        new
                        {
                            Id = new Guid("4564c470-a4db-48e3-856b-406015c3e14a"),
                            Date = new DateTime(2022, 6, 22, 20, 1, 45, 397, DateTimeKind.Local).AddTicks(6486),
                            FreightValue = 75m,
                            InsuranceValue = 150.23m,
                            InvoiceNumber = "11312272"
                        });
                });

            modelBuilder.Entity("Zip2Clear.Data.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Department")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("DutyExciseRate")
                        .HasColumnType("REAL");

                    b.Property<double>("DutyGeneralRate")
                        .HasColumnType("REAL");

                    b.Property<double>("HsCode")
                        .HasColumnType("REAL");

                    b.Property<Guid?>("InvoiceId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<string>("UomId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("UomValue")
                        .HasColumnType("REAL");

                    b.Property<decimal>("Value")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e1a87118-4d25-46a9-b90e-ac91c0710316"),
                            Department = "MS",
                            Description = "INNER TUBES",
                            DutyExciseRate = 45.0,
                            DutyGeneralRate = 0.0,
                            HsCode = 40131000.0,
                            Quantity = 1.0,
                            UomId = "EA",
                            UomValue = 1.0,
                            Value = 54.85m,
                            Weight = 50.0
                        },
                        new
                        {
                            Id = new Guid("ab2e8122-873c-4915-8338-c83da2148774"),
                            Department = "MS",
                            Description = "TIRES, CAR",
                            DutyExciseRate = 25.0,
                            DutyGeneralRate = 0.0,
                            HsCode = 40111000.0,
                            Quantity = 1.0,
                            UomId = "EA",
                            UomValue = 1.0,
                            Value = 168.25m,
                            Weight = 150.0
                        },
                        new
                        {
                            Id = new Guid("3ee5a0f5-ad95-465f-80bb-b469a2e5ead9"),
                            Department = "MS",
                            Description = "AUTO PARTS",
                            DutyExciseRate = 60.0,
                            DutyGeneralRate = 0.0,
                            HsCode = 87071010.0,
                            Quantity = 49.0,
                            UomId = "EA",
                            UomValue = 49.0,
                            Value = 691.78m,
                            Weight = 100.0
                        },
                        new
                        {
                            Id = new Guid("cebd7bd1-ac68-41f0-a9bc-dc133f7d7136"),
                            Department = "MS",
                            Description = "AUTO PARTS",
                            DutyExciseRate = 60.0,
                            DutyGeneralRate = 0.0,
                            HsCode = 87071010.0,
                            Quantity = 5.0,
                            UomId = "EA",
                            UomValue = 5.0,
                            Value = 55.89m,
                            Weight = 90.0
                        },
                        new
                        {
                            Id = new Guid("2c7f0583-2f23-4ba2-94a8-5a2d26bdc4bb"),
                            Department = "MF",
                            Description = "ONION BAGS",
                            DutyExciseRate = 0.0,
                            DutyGeneralRate = 45.0,
                            HsCode = 39232990.0,
                            Quantity = 4.0,
                            UomId = "LB",
                            UomValue = 40.0,
                            Value = 528m,
                            Weight = 40.0
                        });
                });

            modelBuilder.Entity("Zip2Clear.Data.Vendor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CityName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vendor");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30751ca9-40ab-4795-a58d-f54ca1a8af6e"),
                            AddressLine = "PO BOX 1723",
                            CityName = "OKEECHOBEE",
                            CountryCode = "US",
                            Name = "WALPOLE FEED",
                            PostalCode = "34973",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("bdcac9c8-4c6d-425b-93a4-f0a0fa1b064c"),
                            AddressLine = "12029 W DOPHIN CT",
                            CityName = "HOMOSASSA",
                            CountryCode = "US",
                            Name = "AGRIVET",
                            PostalCode = "34448",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("701b17c1-80bb-46d2-9a49-acaf1adda5dc"),
                            AddressLine = "1301 SW 2ND ST",
                            CityName = "POMPANO BEACH",
                            CountryCode = "US",
                            Name = "ROADWAY TIRES",
                            PostalCode = "33069",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("870faad4-7943-4252-ab99-bf60a3081a5f"),
                            AddressLine = "2968 RAVENSWOOD ROAD",
                            CityName = "FORT LAUDERDALE",
                            CountryCode = "US",
                            Name = "TPH",
                            PostalCode = "33312",
                            State = "FL"
                        },
                        new
                        {
                            Id = new Guid("464c2657-1240-41b7-b8b1-2588e7aa9617"),
                            AddressLine = "4300 STEWART ROAD",
                            CityName = "LAKELAND",
                            CountryCode = "US",
                            Name = "MONTE PACKAGE",
                            PostalCode = "33815",
                            State = "FL"
                        });
                });

            modelBuilder.Entity("Zip2Clear.Data.Invoice", b =>
                {
                    b.HasOne("Zip2Clear.Data.Declaration", "Declaration")
                        .WithMany()
                        .HasForeignKey("DeclarationId");

                    b.HasOne("Zip2Clear.Data.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId");

                    b.Navigation("Declaration");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("Zip2Clear.Data.Item", b =>
                {
                    b.HasOne("Zip2Clear.Data.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId");

                    b.Navigation("Invoice");
                });
#pragma warning restore 612, 618
        }
    }
}
