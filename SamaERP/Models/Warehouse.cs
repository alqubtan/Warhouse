using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class Warehouse
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string WarhouseName { get; set; }
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string WarehouseDescription { get; set; }
        [Required]
        public string WarehouseBranch { get; set; }
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string WarehouseAddress { get; set; }
    }
}
