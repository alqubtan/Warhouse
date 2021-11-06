using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class WarDeliverd
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        [Display(Name = "Serial No.")]
        public string SerialNo { get; set; }
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        [Display(Name = "Barcode")]
        public string Barcode  { get; set; }
        [Required]
        [Display(Name ="Unit")]
        public string Unit { get; set; }
        [Required]
        
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        [Display(Name = "Branch Name")]
        public string BranchName { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        [Display(Name = "Warehouse Name")]
        public string WarehouseName { get; set; }
        [Display(Name = "Deliver Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DeliverDate { get; set; }
        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        public string OrderNumber { get; set; }
        public int ActiveOrNot { get; set; }
    }
}
