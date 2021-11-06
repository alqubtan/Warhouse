using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class WarCustomerType
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string CustomerType { get; set; }
        
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string  CustomerTypeDescription { get; set; }
    }
}
