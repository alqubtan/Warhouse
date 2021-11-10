using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SamaERP.Models
{
    public class WarSupplierType
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name ="Supplier Type")]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string SupplierType { get; set; }
        [Display(Name = "Supplier Description")]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string SupplierDescription { get; set; }
    }
}
