﻿using Microsoft.EntityFrameworkCore;

namespace Zip2Clear.Data
{ 
    public class MyDbContext : DbContext
    {
        #region Constructor
        public MyDbContext(DbContextOptions<MyDbContext> options)
                : base(options)
        {

        }
        #endregion

        #region Public properties
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Declaration> Declaration { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Tarriff> Tarriff { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendor>().HasData(GetVendors());
            modelBuilder.Entity<Invoice>().HasData(GetInvoices());
            modelBuilder.Entity<Declaration>().HasData(GetDeclarations());
            modelBuilder.Entity<Tarriff>().HasData(GetTarriffs());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Private methods
        private List<Vendor> GetVendors()
        {
            return new List<Vendor>
            {
                new Vendor { Id = Guid.NewGuid(), Name = "WALPOLE FEED", AddressLine = "PO BOX 1723", CityName = "OKEECHOBEE", State = "FL", PostalCode = "34973", CountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), Name = "AGRIVET", AddressLine = "12029 W DOPHIN CT", CityName = "HOMOSASSA", State = "FL", PostalCode = "34448", CountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), Name = "ROADWAY TIRES", AddressLine = "1301 SW 2ND ST", CityName = "POMPANO BEACH", State = "FL", PostalCode = "33069", CountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), Name = "TPH", AddressLine = "2968 RAVENSWOOD ROAD", CityName = "FORT LAUDERDALE", State = "FL", PostalCode = "33312", CountryCode = "US" },
                new Vendor { Id = Guid.NewGuid(), Name = "MONTE PACKAGE", AddressLine = "4300 STEWART ROAD", CityName = "LAKELAND", State = "FL", PostalCode = "33815", CountryCode = "US" }
            };
        }

        private List<Declaration> GetDeclarations()
        {
            return new List<Declaration>
            {
                new Declaration { Id = Guid.NewGuid(), Regime = "4", Type = "400", ModeOfTransport = "1", DeclarationOffice = "SAQPDK", DeclarationNumber = "2022DEC0000845484", CountryOfOrigin = "US", CountryOfDestination = "BS", PortOfEntry = "SAQ", PortOfExit = "USPVS", Exporter = "Mennonite Messianic Mission", Importer = "Mennonite Messianic Mission", CreatedDate = DateTime.Now, SubmittedDate = DateTime.Now, TotalPackageQnty = 1, TotalPackageQntyUOM = "EA", TotalGrossMassMeasureQnty = 390, TotalGrossMassMeasureUOM = "LB", Submitted = true, Status = "Compliance", ManifestNumber = "MSTRNO30613", BOLnumber = "PEVMOB005095" },
                new Declaration { Id = Guid.NewGuid(), Regime = "4", Type = "400", ModeOfTransport = "1", DeclarationOffice = "SAQPDK", DeclarationNumber = "2022DEC0000845474", CountryOfOrigin = "US", CountryOfDestination = "BS", PortOfEntry = "SAQ", PortOfExit = "USPVS", Exporter = "Mennonite Messianic Mission", Importer = "Mennonite Messianic Mission", CreatedDate = DateTime.Now, SubmittedDate = DateTime.Now, TotalPackageQnty = 1, TotalPackageQntyUOM = "EA", TotalGrossMassMeasureQnty = 40, TotalGrossMassMeasureUOM = "LB", Submitted = true, Status = "Compliance", ManifestNumber = "MSTRNO30613", BOLnumber = "PEVMOB005096" }
            };
        }

        private List<Invoice> GetInvoices()
        {
            return new List<Invoice>
            {
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "814184793", Shipping = 0M, Insurance = 150M },
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "2022ES7023", Shipping = 0M, Insurance = 0M },
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "2022ES8200", Shipping = 0M, Insurance = 0M },
                new Invoice { Id = Guid.NewGuid(), Date = DateTime.Now, InvoiceNumber = "11312272", Shipping = 75M, Insurance = 150.23M }
            };
        }

        private List<Tarriff> GetTarriffs()
        {
            return new List<Tarriff>
            {
                new Tarriff { Id = Guid.NewGuid(), Name = "APPLES", Number = 08081000, UomId = "LB", GeneralRate = 0, ExciseRate = 0 },
                new Tarriff { Id = Guid.NewGuid(), Name = "BATTERIES", Number = 85073000, UomId = "EA", GeneralRate = 45, ExciseRate = 0 },
                new Tarriff { Id = Guid.NewGuid(), Name = "CANDY", Number = 17049010, UomId = "LB", GeneralRate = 60, ExciseRate = 0 }
            };
        }
        #endregion
    }
}