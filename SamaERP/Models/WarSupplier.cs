using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class WarSupplier
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string SupplierName { get; set; }
        [Required]
        public string SupplierType { get; set; }
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string SupplierDescription { get; set; }
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string SupplierPhoneNo { get; set; }
        [EmailAddress]
        public string SupplierEmail { get; set; }
      
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string SupplierAddress { get; set; }
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string SupplierCountry { get; set; }
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string SupplierCity { get; set; }
    }
}
