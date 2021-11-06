using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class WarReceivedProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string  ProductName { get; set; }
        
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string SNumber { get; set; }
        
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string ProductBarcode { get; set; }
        [Required]
        
        public string ProductSupplier { get; set; }

        [Required]
        public string ProductUnit { get; set; }
        [Required]
        public int ProductQty { get; set; }

        [Required]
        public string BranchName { get; set; }
        [Required]
        public string WarehouseName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ProductExpireDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime RecivedDate { get; set; }

        public string InvoiceNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InvoiceDate { get; set; }
    }
}
