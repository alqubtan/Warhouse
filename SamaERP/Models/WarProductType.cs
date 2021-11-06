using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class WarProductType
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        [Display(Name ="Product type")]
        public string productType { get; set; }
        [Display(Name = "Description")]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string productTypeDescription { get; set; }
    }
}
