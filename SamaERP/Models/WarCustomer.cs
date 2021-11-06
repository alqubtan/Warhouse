using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class WarCustomer
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerType { get; set; }
        
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string CustomerDepartment { get; set; }
        
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string CustomerDecription { get; set; }
        
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string CustomerPhoneNo { get; set; }
        
        [EmailAddress]
        public string CustomerEmail { get; set; }
        
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string CustomerAddress { get; set; }
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string CustomerCountry { get; set; }
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string CustomerCity { get; set; }
    }
}
