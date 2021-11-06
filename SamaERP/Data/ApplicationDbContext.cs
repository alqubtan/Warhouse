using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SamaERP.Models;

namespace SamaERP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
          
        }
        public DbSet<Models.WarBranch> WarBranch { get; set; }

        public DbSet<Models.Warehouse> Warehouse { get; set; }
        public DbSet<Models.WarCustomer> WarCustomer { get; set; }
        public DbSet<Models.WarProduct> WarProduct { get; set; }
        public DbSet<Models.WarProductType> WarProductType { get; set; }
        public DbSet<Models.WarSupplier> WarSupplier { get; set; }
        public DbSet<Models.WarReceivedProduct> WarReceivedProduct { get; set; }
        public DbSet<Models.WarCustomerType> WarCustomerType { get; set; }
        public DbSet<SamaERP.Models.WarDeliverd> WarDeliverd { get; set; }

        







    }
}
